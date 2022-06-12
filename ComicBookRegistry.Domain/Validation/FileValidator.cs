using ComicBookRegistry.Application.Dtos;
using ComicBookRegistry.Domain.Constants;
using ComicBookRegistry.Domain.Exceptions;
using System.IO;
using System.Linq;

namespace ComicBookRegistry.Domain.Validation
{
    public class FileValidator : IFileValidator
    {
        private readonly string[] _acceptedExtensions =
        {
            FileConstants.Jpg,
            FileConstants.Jpeg,
            FileConstants.Png,
            FileConstants.Bmp,
        };

        public void Validate(FileToUploadDto file)
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
    }
}
