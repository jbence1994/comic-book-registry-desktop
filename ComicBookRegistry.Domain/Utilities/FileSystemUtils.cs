using ComicBookRegistry.Application.Dtos;
using ComicBookRegistry.Domain.Constants;
using System;
using System.IO;

namespace ComicBookRegistry.Domain.Utilities
{
    public class FileSystemUtils : IFileUtils
    {
        public byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        public string CreateUploadsDirectory(string contentRootPath)
        {
            var uploadsDirectoryPath = Path.Combine(contentRootPath, FileConstants.ComicBookPhotoUploadsDirectoryPath);

            if (!Directory.Exists(uploadsDirectoryPath))
            {
                Directory.CreateDirectory(uploadsDirectoryPath);
            }

            return uploadsDirectoryPath;
        }

        public string Store(FileToUploadDto file, string uploadsDirectoryPath)
        {
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.Name)}";
            var sourcePath = file.FullQualifiedPathWithFileName;
            var destinationPath = Path.Combine(uploadsDirectoryPath, fileName);
            File.Copy(sourcePath, destinationPath);
            return fileName;
        }
    }
}
