using System;

namespace ComicBookRegistry.Domain.Exceptions
{
    public class MaximumFileSizeExceededException : Exception
    {
        public MaximumFileSizeExceededException()
            : base("Maximum file size exceeded.")
        {
        }
    }
}
