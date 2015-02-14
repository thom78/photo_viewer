namespace viewer
{
    partial class ListAlbums
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
            this.AllPhotosGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AlbumGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.créerAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diaporamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllPhotosGrid
            // 
            this.AllPhotosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllPhotosGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AllPhotosGrid.Location = new System.Drawing.Point(12, 316);
            this.AllPhotosGrid.Name = "AllPhotosGrid";
            this.AllPhotosGrid.Size = new System.Drawing.Size(808, 187);
            this.AllPhotosGrid.TabIndex = 0;
            this.AllPhotosGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.AlbumGrid_Paint);
            // 
            // openFileDialog1
            //
            this.openPictureDialog.Multiselect = true;
            this.openPictureDialog.Filter = "Images (*.jpeg,*.jpg,*.png,*.bmp,*.gif)|*.jpeg;*.jpg;*.png;*.bmp;*.gif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Photos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Albums";
            // 
            // AlbumGrid
            // 
            this.AlbumGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlbumGrid.Location = new System.Drawing.Point(12, 59);
            this.AlbumGrid.Name = "AlbumGrid";
            this.AlbumGrid.Size = new System.Drawing.Size(808, 235);
            this.AlbumGrid.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerAlbumToolStripMenuItem,
            this.importerPhotosToolStripMenuItem,
            this.diaporamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // créerAlbumToolStripMenuItem
            // 
            this.créerAlbumToolStripMenuItem.Name = "créerAlbumToolStripMenuItem";
            this.créerAlbumToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.créerAlbumToolStripMenuItem.Text = "Créer album";
            this.créerAlbumToolStripMenuItem.Click += new System.EventHandler(this.créerAlbumToolStripMenuItem_Click);
            // 
            // importerPhotosToolStripMenuItem
            // 
            this.importerPhotosToolStripMenuItem.Name = "importerPhotosToolStripMenuItem";
            this.importerPhotosToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.importerPhotosToolStripMenuItem.Text = "Importer photos";
            this.importerPhotosToolStripMenuItem.Click += new System.EventHandler(this.importerPhotosToolStripMenuItem_Click);
            // 
            // diaporamaToolStripMenuItem
            // 
            this.diaporamaToolStripMenuItem.Name = "diaporamaToolStripMenuItem";
            this.diaporamaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.diaporamaToolStripMenuItem.Text = "Diaporama";
            this.diaporamaToolStripMenuItem.Click += new System.EventHandler(this.diaporamaToolStripMenuItem_Click);
            // 
            // ListAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 515);
            this.Controls.Add(this.AlbumGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllPhotosGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListAlbums";
            this.Text = "Liste des albums ";
            this.Load += new System.EventHandler(this.ListAlbums_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AllPhotosGrid;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel AlbumGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem créerAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerPhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diaporamaToolStripMenuItem;
    }
}