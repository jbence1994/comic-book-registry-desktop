using System.Diagnostics;
using System.Windows.Forms;

namespace ComicBookRegistry.UI.ModalWindows
{
    public partial class ComicModalWindow : Form
    {
        public ComicModalWindow()
        {
            InitializeComponent();
        }

        private void PictureBoxComicBookCover_Click(object sender, System.EventArgs e)
        {
            Debug.WriteLine("Uploading new image for comic book cover.");
        }
    }
}
