using ComicBookRegistry.Application.Dtos;
using ComicBookRegistry.Core.Repositories;
using ComicBookRegistry.Domain.Exceptions;
using ComicBookRegistry.Domain.Services;
using ComicBookRegistry.Domain.Tests.TestBuilders;
using ComicBookRegistry.Domain.Utilities;
using ComicBookRegistry.Domain.Validation;
using Moq;
using NUnit.Framework;
using System.IO;

namespace ComicBookRegistry.Domain.Tests.Services
{
    [TestFixture]
    public class ComicBookPhotoServiceTests
    {
        private Mock<IComicBookRepository> _comicBookRepository;
        private Mock<IFileUtils> _fileUtils;
        private Mock<IFileValidator> _fileValidator;
        private ComicBookPhotoService _comicBookPhotoService;

        [SetUp]
        public void SetUp()
        {
            _comicBookRepository = new Mock<IComicBookRepository>();
            _fileUtils = new Mock<IFileUtils>();
            _fileValidator = new Mock<IFileValidator>();
            _comicBookPhotoService = new ComicBookPhotoService(
                _comicBookRepository.Object,
                _fileUtils.Object,
                _fileValidator.Object
            );
        }

        [Test]
        public void GetPhotoTest_HappyPath()
        {
            var comicBookPhoto = new byte[1];

            _fileUtils
                .Setup(fileUtils => fileUtils.ReadAllBytes(It.IsAny<string>()))
                .Returns(comicBookPhoto);

            Assert.IsNotEmpty(comicBookPhoto);
            Assert.DoesNotThrow(() => _comicBookPhotoService.GetPhoto(It.IsAny<string>()));
        }

        [Test]
        public void GetPhotoTest_UnhappyPath()
        {
            _fileUtils
                .Setup(fileUtils => fileUtils.ReadAllBytes(It.IsAny<string>()))
                .Throws(new IOException());

            Assert.That(
                () => _comicBookPhotoService.GetPhoto(It.IsAny<string>()),
                Throws.TypeOf<ComicBookPhotoNotFoundException>()
            );
        }

        [Test]
        public void UploadPhotoTest_HappyPath()
        {
            var comicBook = ComicBookTestBuilder.Dummy;

            _comicBookRepository
                .Setup(comicBookRepository => comicBookRepository.GetComicBook(It.IsAny<int>()))
                .Returns(comicBook);

            _fileUtils
                .Setup(fileUtils => fileUtils.Store(
                        It.IsAny<FileToUploadDto>(),
                        It.IsAny<string>()
                    )
                )
                .Returns("00000000-0000-0000-0000-000000000000.jpg");

            var uploadedPhoto = _comicBookPhotoService.UploadPhoto(
                It.IsAny<string>(),
                It.IsAny<FileToUploadDto>(),
                It.IsAny<int>()
            );

            Assert.IsNotNull(uploadedPhoto.FileName);
        }

        [Test]
        public void UploadPhotoTest_UnhappyPath_ShouldThrowNullFileException()
        {
            _fileValidator
                .Setup(fileValidator => fileValidator.Validate(It.IsAny<FileToUploadDto>()))
                .Throws<NullFileException>();

            Assert.That(
                () => _comicBookPhotoService.UploadPhoto(
                    It.IsAny<string>(),
                    It.IsAny<FileToUploadDto>(),
                    It.IsAny<int>()
                ),
                Throws.TypeOf<NullFileException>()
            );
        }

        [Test]
        public void UploadPhotoTest_UnhappyPath_ShouldThrowEmptyFileException()
        {
            _fileValidator
                .Setup(fileValidator => fileValidator.Validate(It.IsAny<FileToUploadDto>()))
                .Throws<MaximumFileSizeExceededException>();

            Assert.That(
                () => _comicBookPhotoService.UploadPhoto(
                    It.IsAny<string>(),
                    It.IsAny<FileToUploadDto>(),
                    It.IsAny<int>()
                ),
                Throws.TypeOf<MaximumFileSizeExceededException>()
            );
        }

        [Test]
        public void UploadPhotoTest_UnhappyPath_ShouldThrowMaximumFileSizeExceededException()
        {
            _fileValidator
                .Setup(fileValidator => fileValidator.Validate(It.IsAny<FileToUploadDto>()))
                .Throws<InvalidFileTypeException>();

            Assert.That(
                () => _comicBookPhotoService.UploadPhoto(
                    It.IsAny<string>(),
                    It.IsAny<FileToUploadDto>(),
                    It.IsAny<int>()
                ),
                Throws.TypeOf<InvalidFileTypeException>()
            );
        }

        [Test]
        public void UploadPhotoTest_UnhappyPath_ShouldThrowInvalidFileTypeException()
        {
            _fileValidator
                .Setup(fileValidator => fileValidator.Validate(It.IsAny<FileToUploadDto>()))
                .Throws<InvalidFileTypeException>();

            Assert.That(
                () => _comicBookPhotoService.UploadPhoto(
                    It.IsAny<string>(),
                    It.IsAny<FileToUploadDto>(),
                    It.IsAny<int>()
                ),
                Throws.TypeOf<InvalidFileTypeException>()
            );
        }

        [Test]
        public void UploadPhotoTest_UnhappyPath_ShouldThrowComicBookNotFoundException()
        {
            _comicBookRepository
                .Setup(comicBookRepository => comicBookRepository.GetComicBook(It.IsAny<int>()))
                .Returns(() => null);

            Assert.That(
                () => _comicBookPhotoService.UploadPhoto(
                    It.IsAny<string>(),
                    It.IsAny<FileToUploadDto>(),
                    It.IsAny<int>()
                ),
                Throws.TypeOf<ComicBookNotFoundException>()
            );
        }
    }
}
