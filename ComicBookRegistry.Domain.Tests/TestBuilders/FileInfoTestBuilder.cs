using System.IO;

namespace ComicBookRegistry.Domain.Tests.TestBuilders
{
    public class FileInfoTestBuilder
    {
        public static FileInfo Default => Build();
        public static FileInfo Null => null;
        public static FileInfo Empty => Build(length: 0);
        public static FileInfo Large => Build(length: 10485761);
        public static FileInfo WithInvalidFileType => Build(fileName: "comic_book_cover.gif");

        private static FileInfo Build(
            int length = 1,
            string name = "photoToUpload",
            string fileName = "comic_book_cover.jpg"
        )
        {
            return new FileInfo(fileName);
        }
    }
}
