using ComicBookRegistry.Application.Dtos;

namespace ComicBookRegistry.Domain.Tests.TestBuilders
{
    public static class FileToUploadDtoTestBuilder
    {
        public static FileToUploadDto Default => Build();
        public static FileToUploadDto Null => null;
        public static FileToUploadDto Empty => Build(length: 0);
        public static FileToUploadDto Large => Build(length: 10485761);
        public static FileToUploadDto WithInvalidFileType => Build(fileName: "comic_book_cover.gif");

        private static FileToUploadDto Build(
            string fileName = "comic_book_cover.jpg",
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
