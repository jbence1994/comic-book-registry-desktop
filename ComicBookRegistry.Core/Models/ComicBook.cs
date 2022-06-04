namespace ComicBookRegistry.Core.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISSN { get; set; }
        public ComicBookPhoto Photo { get; set; }

        public void InitializePhoto(string fileName)
        {
            Photo = new ComicBookPhoto { FileName = fileName };
        }
    }
}
