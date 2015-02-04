namespace viewer
{
    partial class ListaAlbums
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaAlbums));
            this.AlbumGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.PhotosDeCouvertureAlbum = new System.Windows.Forms.ImageList(this.components);
            this.createAlbumButton = new System.Windows.Forms.Button();
            this.but_import = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // AlbumGrid
            // 
            this.AlbumGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumGrid.Location = new System.Drawing.Point(12, 41);
            this.AlbumGrid.Name = "AlbumGrid";
            this.AlbumGrid.Size = new System.Drawing.Size(808, 462);
            this.AlbumGrid.TabIndex = 0;
            // 
            // PhotosDeCouvertureAlbum
            // 
            this.PhotosDeCouvertureAlbum.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PhotosDeCouvertureAlbum.ImageStream")));
            this.PhotosDeCouvertureAlbum.TransparentColor = System.Drawing.Color.Transparent;
            this.PhotosDeCouvertureAlbum.Images.SetKeyName(0, "022.jpg");
            this.PhotosDeCouvertureAlbum.Images.SetKeyName(1, "118.jpg");
            this.PhotosDeCouvertureAlbum.Images.SetKeyName(2, "181.jpg");
            // 
            // createAlbumButton
            // 
            this.createAlbumButton.Location = new System.Drawing.Point(12, 12);
            this.createAlbumButton.Name = "createAlbumButton";
            this.createAlbumButton.Size = new System.Drawing.Size(75, 23);
            this.createAlbumButton.TabIndex = 1;
            this.createAlbumButton.Text = "Creer album";
            this.createAlbumButton.UseVisualStyleBackColor = true;
            this.createAlbumButton.Click += new System.EventHandler(this.createAlbumButton_Click);
            // 
            // but_import
            // 
            this.but_import.Location = new System.Drawing.Point(93, 12);
            this.but_import.Name = "but_import";
            this.but_import.Size = new System.Drawing.Size(92, 23);
            this.but_import.TabIndex = 2;
            this.but_import.Text = "Importer Photos";
            this.but_import.UseVisualStyleBackColor = true;
            this.but_import.Click += new System.EventHandler(this.but_import_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ListaAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 515);
            this.Controls.Add(this.but_import);
            this.Controls.Add(this.createAlbumButton);
            this.Controls.Add(this.AlbumGrid);
            this.Name = "ListaAlbums";
            this.Text = "Liste des albums ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AlbumGrid;
        private System.Windows.Forms.ImageList PhotosDeCouvertureAlbum;
        private System.Windows.Forms.Button createAlbumButton;
        private System.Windows.Forms.Button but_import;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}