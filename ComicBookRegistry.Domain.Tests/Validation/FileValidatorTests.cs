using ComicBookRegistry.Domain.Exceptions;
using ComicBookRegistry.Domain.Tests.TestBuilders;
using ComicBookRegistry.Domain.Validation;
using NUnit.Framework;

namespace ComicBookRegistry.Domain.Tests.Validation
{
    [TestFixture]
    public class FileValidatorTests
    {
        private FileValidator _fileValidator;

        [SetUp]
        public void SetUp()
        {
            _fileValidator = new FileValidator();
        }

        [Test]
        public void ValidateTest_HappyPath()
        {
            var file = FileInfoTestBuilder.Default;

            Assert.DoesNotThrow(() => _fileValidator.Validate(file));
        }

        [Test]
        public void ValidateTest_UnhappyPath_ShouldThrowNullFileException()
        {
            var file = FileInfoTestBuilder.Null;

            Assert.That(
                () => _fileValidator.Validate(file),
                Throws.TypeOf<NullFileException>()
            );
        }

        [Test]
        public void ValidateTest_UnhappyPath_ShouldThrowEmptyFileException()
        {
            var file = FileInfoTestBuilder.Empty;

            Assert.That(
                () => _fileValidator.Validate(file),
                Throws.TypeOf<EmptyFileException>()
            );
        }

        [Test]
        public void ValidateTest_UnhappyPath_ShouldThrowMaximumFileSizeExceededException()
        {
            var file = FileInfoTestBuilder.Large;

            Assert.That(
                () => _fileValidator.Validate(file),
                Throws.TypeOf<MaximumFileSizeExceededException>()
            );
        }

        [Test]
        public void ValidateTest_UnhappyPath_ShouldThrowInvalidFileTypeException()
        {
            var file = FileInfoTestBuilder.WithInvalidFileType;

            Assert.That(
                () => _fileValidator.Validate(file),
                Throws.TypeOf<InvalidFileTypeException>()
            );
        }
    }
}
