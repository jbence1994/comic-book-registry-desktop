namespace ComicBookRegistry.UI.Windows
{
    partial class MainWindow
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
            this.buttonAddComic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddComic
            // 
            this.buttonAddComic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddComic.Location = new System.Drawing.Point(12, 674);
            this.buttonAddComic.Name = "buttonAddComic";
            this.buttonAddComic.Size = new System.Drawing.Size(227, 43);
            this.buttonAddComic.TabIndex = 0;
            this.buttonAddComic.Text = "Képregény hozzáadása";
            this.buttonAddComic.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.buttonAddComic);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Képregény nyilvántartó";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddComic;
    }
}