using ComicBookRegistry.Core.Models;
using ComicBookRegistry.Domain.Tests.Constants;

namespace ComicBookRegistry.Domain.Tests.TestBuilders
{
    public static class ComicBookPhotoTestBuilder
    {
        public static ComicBookPhoto Default => Build();

        public static ComicBookPhoto Build(
            string fileName = TestConstants.PhotoFileName
        )
        {
            return new ComicBookPhoto
            {
                FileName = fileName
            };
        }
    }
}
