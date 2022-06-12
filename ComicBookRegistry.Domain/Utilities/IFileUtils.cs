using ComicBookRegistry.Application.Dtos;

namespace ComicBookRegistry.Domain.Utilities
{
    public interface IFileUtils
    {
        byte[] ReadAllBytes(string path);
        string CreateUploadsDirectory(string contentRootPath);
        string Store(FileToUploadDto file, string uploadsDirectoryPath);
    }
}
