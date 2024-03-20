using ComicBookRegistry.UI.ModalWindows;
using System;
using System.Windows.Forms;

namespace ComicBookRegistry.UI.Windows
{
    public partial class MainWindow : Form
    {
        private readonly ComicBookModalWindow _comicBookModalWindow;

        public MainWindow(ComicBookModalWindow comicBookModalWindow)
        {
            InitializeComponent();

            _comicBookModalWindow = comicBookModalWindow;
        }

        private void ButtonAddComic_Click(object sender, EventArgs e)
        {
            _comicBookModalWindow.ShowDialog();
        }
    }
}
