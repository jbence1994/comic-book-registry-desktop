namespace ComicBookRegistry.Core.Models
{
    public class Comic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public ComicPhoto Photo { get; set; }
    }
}
