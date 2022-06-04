using ComicBookRegistry.Core.Models;
using ComicBookRegistry.Core.Repositories;
using ComicBookRegistry.Domain.Constants;
using ComicBookRegistry.Domain.Exceptions;
using ComicBookRegistry.Domain.Utilities;
using ComicBookRegistry.Domain.Validation;
using System.IO;

namespace ComicBookRegistry.Domain.Services
{
    public class ComicBookPhotoService
    {
        private readonly IComicBookRepository _comicBookRepository;
        private readonly FileUtils _fileUtils;
        private readonly FileValidator _fileValidator;

        public ComicBookPhotoService(
            IComicBookRepository comicBookRepository,
            FileUtils fileUtils,
            FileValidator fileValidator
        )
        {
            _comicBookRepository = comicBookRepository;
            _fileUtils = fileUtils;
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

        public ComicBookPhoto UploadPhoto(string contentRootPath, FileInfo file, int id)
        {
            _fileValidator.Validate(file);

            var comicBook = _comicBookRepository.GetComicBook(id);

            if (comicBook is null)
            {
                throw new ComicBookNotFoundException(id);
            }

            var uploadsDirectoryPath = Path.Combine(contentRootPath, FileConstants.ComicBookPhotoUploadsDirectoryPath);

            _fileUtils.CreateUploadsDirectoryIfNotExist(uploadsDirectoryPath);

            var fileName = _fileUtils.StoreToFileSystem(file, uploadsDirectoryPath);
            comicBook.InitializePhoto(fileName);

            // TODO: Persist photo's name to database.

            return comicBook.Photo;
        }
    }
}
