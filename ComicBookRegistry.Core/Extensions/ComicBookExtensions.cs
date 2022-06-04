﻿using ComicBookRegistry.Core.Models;

namespace ComicBookRegistry.Core.Utilities
{
    public static class ComicBookExtensions
    {
        public static void InitializePhoto(this ComicBook comicBook, string fileName)
        {
            comicBook.Photo = new ComicBookPhoto
            {
                FileName = fileName
            };
        }
    }
}