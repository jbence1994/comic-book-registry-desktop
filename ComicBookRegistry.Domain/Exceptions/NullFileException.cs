using System;

namespace ComicBookRegistry.Domain.Exceptions
{
    public class NullFileException : Exception
    {
        public NullFileException()
            : base("Null file.")
        {
        }
    }
}
