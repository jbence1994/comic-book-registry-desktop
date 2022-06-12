using ComicBookRegistry.Application.Dtos;
using System.IO;

namespace ComicBookRegistry.Application.Mapping
{
    public class FileInfoToFileToUploadDtoMapper
    {
        public FileToUploadDto Map(FileInfo fileInfo)
        {
            return new FileToUploadDto
            {
                Name = fileInfo.Name,
                FullQualifiedPathWithFileName = fileInfo.FullName,
                Length = fileInfo.Length
            };
        }
    }
}
