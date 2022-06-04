using ComicBookRegistry.Core.Models;

namespace ComicBookRegistry.Core.Repositories
{
    public class MockComicBookRepository : IComicBookRepository
    {
        public ComicBook GetComicBook(int id)
        {
            return new ComicBook
            {
                Id = id,
                Title = "Marvel Annual #1",
                ISSN = "0000-0000",
                Photo = null
            };
        }
    }
}
