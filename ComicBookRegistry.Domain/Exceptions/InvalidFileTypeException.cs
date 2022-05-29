using System;

namespace ComicBookRegistry.Domain.Exceptions
{
    public class InvalidFileTypeException : Exception
    {
        public InvalidFileTypeException()
            : base("Invalid file type.")

        {
        }
    }
}
