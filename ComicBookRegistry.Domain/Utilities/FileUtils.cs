using ComicBookRegistry.Application.Dtos;
using System;
using System.IO;

namespace ComicBookRegistry.Domain.Utilities
{
    public class FileUtils
    {
        public byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        public void CreateUploadsDirectoryIfNotExist(string uploadsDirectoryPath)
        {
            if (!Directory.Exists(uploadsDirectoryPath))
            {
                Directory.CreateDirectory(uploadsDirectoryPath);
            }
        }

        public string StoreToFileSystem(FileToUploadDto file, string uploadsDirectoryPath)
        {
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.Name)}";
            var sourcePath = file.FullQualifiedPathWithFileName;
            var destinationPath = Path.Combine(uploadsDirectoryPath, fileName);
            File.Copy(sourcePath, destinationPath);
            return fileName;
        }
    }
}
