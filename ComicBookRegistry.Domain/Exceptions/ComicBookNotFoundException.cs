using System;

namespace ComicBookRegistry.Domain.Exceptions
{
    public class ComicBookNotFoundException : Exception
    {
        public ComicBookNotFoundException(int comicBookId)
            : base($"Comic book not found with id: {comicBookId}.")
        {
        }
    }
}
