using ComicBookRegistry.Core.Models;

namespace ComicBookRegistry.Core.Repositories
{
    public interface IComicBookRepository
    {
        ComicBook GetComicBook(int id);
    }
}
