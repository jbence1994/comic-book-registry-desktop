using ComicBookRegistry.Application.Dtos;
using System.IO;

namespace ComicBookRegistry.Application.Mapping
{
    public class FileInfoToFileToUploadDtoMapper
    {
        public FileToUploadDto MapFrom(FileInfo fileInfo)
        {
            return new FileToUploadDto
            {
                Name = fileInfo.Name,
                Length = fileInfo.Length
            };
        }
    }
}
