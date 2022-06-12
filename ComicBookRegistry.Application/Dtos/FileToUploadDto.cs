namespace ComicBookRegistry.Application.Dtos
{
    public class FileToUploadDto
    {
        public string Name { get; set; }
        public string FullQualifiedPathWithFileName { get; set; }
        public long Length { get; set; }
    }
}
