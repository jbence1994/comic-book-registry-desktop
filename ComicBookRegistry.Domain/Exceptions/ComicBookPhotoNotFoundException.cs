using System;

namespace ComicBookRegistry.Domain.Exceptions
{
    public class ComicBookPhotoNotFoundException : Exception
    {
        public ComicBookPhotoNotFoundException(string fileName)
            : base($"Photo of comic book not found with file name: {fileName}.")
        {
        }
    }
}
