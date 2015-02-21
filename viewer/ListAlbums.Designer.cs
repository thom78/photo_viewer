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
            this.AlbumGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.créerAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diaporamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllPhotosGrid
            // 
            this.AllPhotosGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllPhotosGrid.Location = new System.Drawing.Point(3, 3);
            this.AllPhotosGrid.Name = "AllPhotosGrid";
            this.AllPhotosGrid.Size = new System.Drawing.Size(818, 459);
            this.AllPhotosGrid.TabIndex = 0;
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.Filter = "Images (*.jpeg,*.jpg,*.png,*.bmp,*.gif)|*.jpeg;*.jpg;*.png;*.bmp;*.gif";
            this.openPictureDialog.Multiselect = true;
            // 
            // AlbumGrid
            // 
            this.AlbumGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumGrid.Location = new System.Drawing.Point(3, 3);
            this.AlbumGrid.Name = "AlbumGrid";
            this.AlbumGrid.Size = new System.Drawing.Size(818, 459);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 491);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AlbumGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AllPhotosGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 515);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListAlbums";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoViewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AllPhotosGrid;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.FlowLayoutPanel AlbumGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem créerAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerPhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diaporamaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}