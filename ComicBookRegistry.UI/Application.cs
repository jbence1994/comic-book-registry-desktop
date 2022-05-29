using ComicBookRegistry.UI.Windows;
using System;
using System.Windows.Forms;

namespace ComicBookRegistry.UI
{
    public static class Application
    {
        [STAThread]
        public static void Main()
        {
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new MainWindow());
        }
    }
}
