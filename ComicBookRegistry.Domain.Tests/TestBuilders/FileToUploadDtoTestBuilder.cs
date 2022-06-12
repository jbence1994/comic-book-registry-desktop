using ComicBookRegistry.Application.Dtos;
using ComicBookRegistry.Domain.Tests.Constants;

namespace ComicBookRegistry.Domain.Tests.TestBuilders
{
    public static class FileToUploadDtoTestBuilder
    {
        public static FileToUploadDto Default => Build();
        public static FileToUploadDto Null => null;
        public static FileToUploadDto Empty => Build(length: 0);
        public static FileToUploadDto Large => Build(length: 10485761);
        public static FileToUploadDto WithInvalidFileType => Build(fileName: TestConstants.FileToUploadWithInvalidFileType);

        private static FileToUploadDto Build(
            string fileName = TestConstants.FileToUploadWithValidFileType,
            long length = 1
        )
        {
            return new FileToUploadDto
            {
                Name = fileName,
                Length = length
            };
        }
    }
}
