using System;

namespace ComicBookRegistry.Domain.Exceptions
{
    public class EmptyFileException : Exception
    {
        public EmptyFileException()
            : base("Empty file.")
        {
        }
    }
}
