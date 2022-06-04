using System;
using System.Diagnostics;
using System.IO;
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
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var sourcePathWithFileName = Path.GetFullPath(openFileDialog.FileName);
                var fileName = Path.GetFileName(openFileDialog.FileName);

                var uploadsFolderPath = $"{System.Windows.Forms.Application.StartupPath}uploads\\comic_books";
                if (!Directory.Exists(uploadsFolderPath))
                {
                    Directory.CreateDirectory(uploadsFolderPath);
                }

                File.Copy(sourcePathWithFileName, $"{uploadsFolderPath}\\{Guid.NewGuid()}.{Path.GetExtension(fileName)}");
            }
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
