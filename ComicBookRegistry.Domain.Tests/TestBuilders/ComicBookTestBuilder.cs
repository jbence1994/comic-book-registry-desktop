using ComicBookRegistry.Core.Models;

namespace ComicBookRegistry.Domain.Tests.TestBuilders
{
    public static class ComicBookTestBuilder
    {
        public static ComicBook Default => Build();
        public static ComicBook Dummy => Build();

        private static ComicBook Build(
            string fileName = "comic_book_cover.jpg",
            long length = 1
        )
        {
            return new ComicBook
            {
            };
        }
    }
}
