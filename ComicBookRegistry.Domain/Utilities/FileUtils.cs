using ComicBookRegistry.Domain.Constants;
using ComicBookRegistry.Domain.Exceptions;
using System;
using System.IO;
using System.Linq;

namespace ComicBookRegistry.Domain.Utilities
{
    public class FileUtils
    {
        private readonly string[] _acceptedExtensions =
        {
            FileConstants.Jpg,
            FileConstants.Jpeg,
            FileConstants.Png,
            FileConstants.Bmp,
        };

        public byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        public void Validate(IFormFile file) // TODO: change type
        {
            if (file == null)
            {
                throw new NullFileException();
            }

            if (file.Length == 0)
            {
                throw new EmptyFileException();
            }

            if (file.Length > FileConstants.MaxFileBytes)
            {
                throw new MaximumFileSizeExceededException();
            }

            if (_acceptedExtensions.All(extension => extension != Path.GetExtension(file.FileName).ToLower()))
            {
                throw new InvalidFileTypeException();
            }
        }

        public string GetUploadsDirectory(string contentRootPath, string uploadsDirectoryRootPath)
        {
            var uploadsDirectoryPath = Path.Combine(contentRootPath, uploadsDirectoryRootPath);

            if (!Directory.Exists(uploadsDirectoryPath))
            {
                Directory.CreateDirectory(uploadsDirectoryPath);
            }

            return uploadsDirectoryPath;
        }

        public string StoreToFileSystem(IFormFile file, string uploadsDirectoryPath)
        {
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            var filePath = Path.Combine(uploadsDirectoryPath, fileName);

            using var stream = new FileStream(filePath, FileMode.Create);
            file.CopyTo(stream);

            return fileName;
        }
    }
}
