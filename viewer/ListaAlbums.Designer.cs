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
            this.AllPhotosGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.PhotosDeCouvertureAlbum = new System.Windows.Forms.ImageList(this.components);
            this.createAlbumButton = new System.Windows.Forms.Button();
            this.but_import = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AlbumGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllPhotosGrid
            // 
            this.AllPhotosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllPhotosGrid.Location = new System.Drawing.Point(12, 316);
            this.AllPhotosGrid.Name = "AllPhotosGrid";
            this.AllPhotosGrid.Size = new System.Drawing.Size(808, 187);
            this.AllPhotosGrid.TabIndex = 0;
            this.AllPhotosGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.AlbumGrid_Paint);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste de toutes ls photos de \"pellicule\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liste des albums (affichage de la premier photo de lalbum)";
            // 
            // AlbumGrid
            // 
            this.AlbumGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumGrid.Location = new System.Drawing.Point(12, 59);
            this.AlbumGrid.Name = "AlbumGrid";
            this.AlbumGrid.Size = new System.Drawing.Size(798, 235);
            this.AlbumGrid.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Diaporama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Diapo_Click);
            // 
            // ListaAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AlbumGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_import);
            this.Controls.Add(this.createAlbumButton);
            this.Controls.Add(this.AllPhotosGrid);
            this.Name = "ListaAlbums";
            this.Text = "Liste des albums ";
            this.Load += new System.EventHandler(this.ListaAlbums_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AllPhotosGrid;
        private System.Windows.Forms.ImageList PhotosDeCouvertureAlbum;
        private System.Windows.Forms.Button createAlbumButton;
        private System.Windows.Forms.Button but_import;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel AlbumGrid;
        private System.Windows.Forms.Button button1;
    }
}