using ComicBookRegistry.Domain.Services;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ComicBookRegistry.UI.ModalWindows
{
    public partial class ComicBookModalWindow : Form
    {
        private readonly OpenFileDialog _openFileDialog;
        private readonly ComicBookPhotoService _comicBookPhotoService;

        public ComicBookModalWindow(
            OpenFileDialog openFileDialog,
            ComicBookPhotoService comicBookPhotoService
        )
        {
            InitializeComponent();

            _openFileDialog = openFileDialog;
            _comicBookPhotoService = comicBookPhotoService;
        }

        private void PictureBoxPhoto_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = _openFileDialog.FileName;
                var fileToUploadWithFullSourcePath = Path.GetFullPath(fileName);
                var file = new FileInfo(fileToUploadWithFullSourcePath);
                var contentRootPath = System.Windows.Forms.Application.StartupPath;

                var photo = _comicBookPhotoService.UploadPhoto(contentRootPath, file, 1);
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
