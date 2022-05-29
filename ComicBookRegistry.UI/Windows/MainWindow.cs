using ComicBookRegistry.UI.ModalWindows;
using System;
using System.Windows.Forms;

namespace ComicBookRegistry.UI.Windows
{
    public partial class MainWindow : Form
    {
        private readonly ComicModalWindow _comicModalWindow;

        public MainWindow(ComicModalWindow comicModalWindow)
        {
            InitializeComponent();

            _comicModalWindow = comicModalWindow;
        }

        private void ButtonAddComic_Click(object sender, EventArgs e)
        {
            _comicModalWindow.ShowDialog();
        }
    }
}
