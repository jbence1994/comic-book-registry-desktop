using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ComicBookRegistry.UI.Windows
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddComic_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Opening modal window for creating a new comic.");
        }
    }
}
