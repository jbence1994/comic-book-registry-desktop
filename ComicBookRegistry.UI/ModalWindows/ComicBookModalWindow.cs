using ComicBookRegistry.Application.Dtos;
using ComicBookRegistry.Application.Mapping;
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
        private readonly FileInfoToFileToUploadDtoMapper _fileInfoToFileToUploadDtoMapper;
        private readonly ComicBookPhotoService _comicBookPhotoService;

        public ComicBookModalWindow(
            OpenFileDialog openFileDialog,
            FileInfoToFileToUploadDtoMapper fileInfoToFileToUploadDtoMapper,
            ComicBookPhotoService comicBookPhotoService
        )
        {
            InitializeComponent();

            _openFileDialog = openFileDialog;
            _fileInfoToFileToUploadDtoMapper = fileInfoToFileToUploadDtoMapper;
            _comicBookPhotoService = comicBookPhotoService;
        }

        private void PictureBoxPhoto_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = _openFileDialog.FileName;
                var fileToUploadWithFullSourcePath = Path.GetFullPath(fileName);
                var file = new FileInfo(fileToUploadWithFullSourcePath);
                var photoToUploadDto = _fileInfoToFileToUploadDtoMapper.Map(file);

                var contentRootPath = System.Windows.Forms.Application.StartupPath;

                var photo = _comicBookPhotoService.UploadPhoto(contentRootPath, photoToUploadDto, 1);
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
