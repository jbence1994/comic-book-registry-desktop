using ComicBookRegistry.Application.Mapping;
using ComicBookRegistry.Core.Repositories;
using ComicBookRegistry.Domain.Services;
using ComicBookRegistry.Domain.Utilities;
using ComicBookRegistry.Domain.Validation;
using ComicBookRegistry.UI.ModalWindows;
using ComicBookRegistry.UI.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace ComicBookRegistry.UI
{
    public static class Application
    {
        [STAThread]
        public static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddScoped<IComicBookRepository, MockComicBookRepository>();

                    services.AddScoped<ComicBookPhotoService>();
                    services.AddScoped<IFileUtils, FileSystemUtils>();
                    services.AddScoped<IFileValidator, FileValidator>();

                    services.AddScoped<FileInfoToFileToUploadDtoMapper>();

                    services.AddScoped<OpenFileDialog>();
                    services.AddScoped<ComicBookModalWindow>();
                    services.AddScoped<MainWindow>();
                })
                .Build();

            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(host.Services.GetRequiredService<ComicBookModalWindow>());
        }
    }
}
