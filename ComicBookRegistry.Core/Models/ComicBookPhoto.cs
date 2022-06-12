namespace ComicBookRegistry.Core.Models
{
    public class ComicBookPhoto : Photo
    {
        public int ComicBookId { get; set; }
        public ComicBook ComicBook { get; set; }
    }
}
