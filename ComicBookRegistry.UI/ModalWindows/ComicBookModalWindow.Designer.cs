namespace ComicBookRegistry.UI.ModalWindows
{
    partial class ComicBookModalWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComicBookModalWindow));
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.groupBoxComicData = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.groupBoxComicData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto.Image")));
            this.pictureBoxPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhoto.InitialImage")));
            this.pictureBoxPhoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(302, 537);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 0;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Click += new System.EventHandler(this.PictureBoxComicBookCover_Click);
            // 
            // groupBoxComicData
            // 
            this.groupBoxComicData.Controls.Add(this.buttonCancel);
            this.groupBoxComicData.Controls.Add(this.textBoxISBN);
            this.groupBoxComicData.Controls.Add(this.buttonSave);
            this.groupBoxComicData.Controls.Add(this.textBoxTitle);
            this.groupBoxComicData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxComicData.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxComicData.Location = new System.Drawing.Point(302, 0);
            this.groupBoxComicData.Name = "groupBoxComicData";
            this.groupBoxComicData.Size = new System.Drawing.Size(402, 537);
            this.groupBoxComicData.TabIndex = 1;
            this.groupBoxComicData.TabStop = false;
            this.groupBoxComicData.Text = "Képregény adatai";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(6, 495);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(390, 36);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxISBN.Location = new System.Drawing.Point(6, 101);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.PlaceholderText = "ISBN szám";
            this.textBoxISBN.Size = new System.Drawing.Size(390, 33);
            this.textBoxISBN.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(6, 453);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(390, 36);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTitle.Location = new System.Drawing.Point(6, 62);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.PlaceholderText = "Képregény címe";
            this.textBoxTitle.Size = new System.Drawing.Size(390, 33);
            this.textBoxTitle.TabIndex = 2;
            // 
            // ComicBookModalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 537);
            this.Controls.Add(this.groupBoxComicData);
            this.Controls.Add(this.pictureBoxPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ComicBookModalWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.groupBoxComicData.ResumeLayout(false);
            this.groupBoxComicData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.GroupBox groupBoxComicData;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Button buttonCancel;
    }
}