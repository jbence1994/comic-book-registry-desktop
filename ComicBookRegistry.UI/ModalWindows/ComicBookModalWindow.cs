using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ComicBookRegistry.UI.ModalWindows
{
    public partial class ComicBookModalWindow : Form
    {
        public ComicBookModalWindow()
        {
            InitializeComponent();
        }

        private void PictureBoxComicBookCover_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Uploading new image for comic book cover.");
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Saving comic book data to database.");
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Cancelling process.");
        }
    }
}
