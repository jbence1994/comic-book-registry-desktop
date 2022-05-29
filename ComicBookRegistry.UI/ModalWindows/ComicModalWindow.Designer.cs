namespace ComicBookRegistry.UI.ModalWindows
{
    partial class ComicModalWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComicModalWindow));
            this.pictureBoxComicBookCover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComicBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxComicBookCover
            // 
            this.pictureBoxComicBookCover.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxComicBookCover.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxComicBookCover.Image")));
            this.pictureBoxComicBookCover.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxComicBookCover.InitialImage")));
            this.pictureBoxComicBookCover.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxComicBookCover.Name = "pictureBoxComicBookCover";
            this.pictureBoxComicBookCover.Size = new System.Drawing.Size(302, 537);
            this.pictureBoxComicBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxComicBookCover.TabIndex = 0;
            this.pictureBoxComicBookCover.TabStop = false;
            // 
            // ComicModalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 537);
            this.Controls.Add(this.pictureBoxComicBookCover);
            this.Name = "ComicModalWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Képregény";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComicBookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxComicBookCover;
    }
}