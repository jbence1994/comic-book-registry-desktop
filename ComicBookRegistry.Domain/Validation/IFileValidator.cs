using ComicBookRegistry.Application.Dtos;

namespace ComicBookRegistry.Domain.Validation
{
    public interface IFileValidator
    {
        void Validate(FileToUploadDto file);
    }
}
