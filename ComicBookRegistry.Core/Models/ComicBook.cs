namespace ComicBookRegistry.Core.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public ComicBookPhoto Photo { get; set; }
    }
}
