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

        public void Validate(FileInfo file)
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

            if (_acceptedExtensions.All(extension => extension != Path.GetExtension(file.Name).ToLower()))
            {
                throw new InvalidFileTypeException();
            }
        }

        public void CreateUploadsDirectoryIfNotExist(string uploadsDirectoryPath)
        {
            if (!Directory.Exists(uploadsDirectoryPath))
            {
                Directory.CreateDirectory(uploadsDirectoryPath);
            }
        }

        public string StoreToFileSystem(FileInfo file, string uploadsDirectoryPath)
        {
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.Name)}";
            var sourcePath = file.FullName;
            var destinationPath = Path.Combine(uploadsDirectoryPath, fileName);
            File.Copy(sourcePath, destinationPath);
            return fileName;
        }
    }
}
