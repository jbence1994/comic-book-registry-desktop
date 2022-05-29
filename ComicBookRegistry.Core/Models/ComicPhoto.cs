namespace ComicBookRegistry.Core.Models
{
    public class ComicPhoto : Photo
    {
        public int ComicId { get; set; }
        public Comic Comic { get; set; }
    }
}
