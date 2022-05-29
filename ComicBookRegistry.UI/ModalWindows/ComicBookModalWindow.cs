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

        private void PictureBoxPhoto_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Uploading new photo for comic book.");
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Saving comic book to database.");
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Cancelling process.");
        }
    }
}
