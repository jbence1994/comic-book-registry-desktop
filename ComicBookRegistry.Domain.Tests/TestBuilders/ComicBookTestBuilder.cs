using ComicBookRegistry.Core.Models;
using ComicBookRegistry.Domain.Tests.Constants;

namespace ComicBookRegistry.Domain.Tests.TestBuilders
{
    public static class ComicBookTestBuilder
    {
        public static ComicBook Default => Build();

        private static ComicBook Build(
            int id = 1,
            string title = TestConstants.Title,
            string ISSN = TestConstants.ISSN
        )
        {
            return new ComicBook
            {
                Id = id,
                Title = title,
                ISSN = ISSN,
                Photo = ComicBookPhotoTestBuilder.Default
            };
        }
    }
}
