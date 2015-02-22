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
        /// <param strName="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.trierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllPhotosGrid
            // 
            this.AllPhotosGrid.AllowDrop = true;
            this.AllPhotosGrid.AutoScroll = true;
            this.AllPhotosGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AllPhotosGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllPhotosGrid.Location = new System.Drawing.Point(0, 0);
            this.AllPhotosGrid.Name = "AllPhotosGrid";
            this.AllPhotosGrid.Size = new System.Drawing.Size(554, 572);
            this.AllPhotosGrid.TabIndex = 0;
            this.AllPhotosGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.AllPhotosGrid_DragDrop);
            this.AllPhotosGrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllPhotosGrid_DragEnter);
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.Filter = "Images (*.jpeg,*.jpg,*.png,*.bmp,*.gif)|*.jpeg;*.jpg;*.png;*.bmp;*.gif";
            this.openPictureDialog.Multiselect = true;
            // 
            // AlbumGrid
            // 
            this.AlbumGrid.AutoScroll = true;
            this.AlbumGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AlbumGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumGrid.Location = new System.Drawing.Point(0, 0);
            this.AlbumGrid.Name = "AlbumGrid";
            this.AlbumGrid.Size = new System.Drawing.Size(266, 572);
            this.AlbumGrid.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerAlbumToolStripMenuItem,
            this.importerPhotosToolStripMenuItem,
            this.diaporamaToolStripMenuItem,
            this.trierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // créerAlbumToolStripMenuItem
            // 
            this.créerAlbumToolStripMenuItem.Name = "créerAlbumToolStripMenuItem";
            this.créerAlbumToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.créerAlbumToolStripMenuItem.Text = "Créer album";
            this.créerAlbumToolStripMenuItem.Click += new System.EventHandler(this.createAlbumToolStripMenuItem_Click);
            // 
            // importerPhotosToolStripMenuItem
            // 
            this.importerPhotosToolStripMenuItem.Name = "importerPhotosToolStripMenuItem";
            this.importerPhotosToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.importerPhotosToolStripMenuItem.Text = "Importer photos";
            this.importerPhotosToolStripMenuItem.Click += new System.EventHandler(this.importPhotosToolStripMenuItem_Click);
            // 
            // diaporamaToolStripMenuItem
            // 
            this.diaporamaToolStripMenuItem.Name = "diaporamaToolStripMenuItem";
            this.diaporamaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.diaporamaToolStripMenuItem.Text = "Diaporama";
            this.diaporamaToolStripMenuItem.Click += new System.EventHandler(this.diaporamaToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AlbumGrid);
            this.splitContainer1.Panel1MinSize = 266;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AllPhotosGrid);
            this.splitContainer1.Panel2MinSize = 266;
            this.splitContainer1.Size = new System.Drawing.Size(824, 572);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.SplitterIncrement = 16;
            this.splitContainer1.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 596);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel1.Text = "En attente";
            // 
            // trierToolStripMenuItem
            // 
            this.trierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomToolStripMenuItem,
            this.dateToolStripMenuItem,
            this.noteToolStripMenuItem});
            this.trierToolStripMenuItem.Name = "trierToolStripMenuItem";
            this.trierToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.trierToolStripMenuItem.Text = "Trier";
            // 
            // nomToolStripMenuItem
            // 
            this.nomToolStripMenuItem.Name = "nomToolStripMenuItem";
            this.nomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nomToolStripMenuItem.Text = "Nom";
            this.nomToolStripMenuItem.Click += new System.EventHandler(this.nomToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // noteToolStripMenuItem
            // 
            this.noteToolStripMenuItem.Name = "noteToolStripMenuItem";
            this.noteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noteToolStripMenuItem.Text = "Note";
            // 
            // ListAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 618);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListAlbums";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoViewer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem trierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuItem;
    }
}