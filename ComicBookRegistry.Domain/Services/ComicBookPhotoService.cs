using ComicBookRegistry.Core.Models;
using ComicBookRegistry.Core.Repositories;
using ComicBookRegistry.Core.Utilities;
using ComicBookRegistry.Domain.Constants;
using ComicBookRegistry.Domain.Exceptions;
using ComicBookRegistry.Domain.Utilities;

namespace ComicBookRegistry.Domain.Services
{
    public class ComicBookPhotoService
    {
        private readonly IComicBookRepository _comicBookRepository;
        private readonly FileUtils _fileUtils;

        public ComicBookPhotoService(FileUtils fileUtils)
        {
            _fileUtils = fileUtils;
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

        public ComicBookPhoto UploadPhoto(string contentRootPath, IFormFile file, int id) // TODO: change type
        {
            _fileUtils.Validate(file);

            var comicBook = _comicBookRepository.GetComicBook(id);

            if (comicBook is null)
            {
                throw new ComicBookNotFoundException(id);
            }

            var uploadsDirectoryPath = _fileUtils.GetUploadsDirectory(contentRootPath, FileConstants.ComicBookPhotoUploadsDirectoryPath);

            var fileName = _fileUtils.StoreToFileSystem(file, uploadsDirectoryPath);
            comicBook.InitializePhoto(fileName);

            // TODO: Save file's name to database.

            return comicBook.Photo;
        }
    }
}
