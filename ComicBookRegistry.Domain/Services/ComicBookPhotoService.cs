using ComicBookRegistry.Application.Dtos;
using ComicBookRegistry.Core.Models;
using ComicBookRegistry.Core.Repositories;
using ComicBookRegistry.Domain.Constants;
using ComicBookRegistry.Domain.Exceptions;
using ComicBookRegistry.Domain.Utilities;
using ComicBookRegistry.Domain.Validation;

namespace ComicBookRegistry.Domain.Services
{
    public class ComicBookPhotoService
    {
        private readonly IComicBookRepository _comicBookRepository;
        private readonly IFileUtils _fileUtils;
        private readonly FileValidator _fileValidator;

        public ComicBookPhotoService(
            IComicBookRepository comicBookRepository,
            IFileUtils fileSystemUtils,
            FileValidator fileValidator
        )
        {
            _comicBookRepository = comicBookRepository;
            _fileUtils = fileSystemUtils;
            _fileValidator = fileValidator;
        }

        public byte[] GetPhoto(string fileName)
        {
            byte[] comicBookPhoto;

            try
            {
                comicBookPhoto = _fileUtils.ReadAllBytes($"{FileConstants.ComicBookPhotoUploadsDirectoryPath}/{fileName}");
            }
            catch
            {
                throw new ComicBookPhotoNotFoundException(fileName);
            }

            return comicBookPhoto;
        }

        public ComicBookPhoto UploadPhoto(string contentRootPath, FileToUploadDto file, int id)
        {
            _fileValidator.Validate(file);

            var comicBook = _comicBookRepository.GetComicBook(id);

            if (comicBook is null)
            {
                throw new ComicBookNotFoundException(id);
            }

            var uploadsDirectoryPath = _fileUtils.CreateUploadsDirectory(contentRootPath);

            var fileName = _fileUtils.Store(file, uploadsDirectoryPath);
            comicBook.InitializePhoto(fileName);

            // TODO: Persist photo's name to database.

            return comicBook.Photo;
        }
    }
}
