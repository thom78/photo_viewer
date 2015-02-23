namespace viewer
{
    partial class VignetteNV
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.pictureBoxHandle = new System.Windows.Forms.PictureBox();
            this.pbPreviewPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHandle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Location = new System.Drawing.Point(5, 5);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(256, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Titre";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(8, 264);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(73, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "JJ/MM/AAAA";
            // 
            // pictureBoxHandle
            // 
            this.pictureBoxHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHandle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHandle.Image = global::viewer.Properties.Resources.Handle1;
            this.pictureBoxHandle.Location = new System.Drawing.Point(234, 256);
            this.pictureBoxHandle.Name = "pictureBoxHandle";
            this.pictureBoxHandle.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxHandle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHandle.TabIndex = 3;
            this.pictureBoxHandle.TabStop = false;
            this.pictureBoxHandle.DragOver += new System.Windows.Forms.DragEventHandler(this.VignetteNV_DragOver);
            this.pictureBoxHandle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VignetteNV_MouseDown);
            // 
            // pbPreviewPicture
            // 
            this.pbPreviewPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPreviewPicture.Image = global::viewer.Properties.Resources.empty;
            this.pbPreviewPicture.Location = new System.Drawing.Point(5, 5);
            this.pbPreviewPicture.Name = "pbPreviewPicture";
            this.pbPreviewPicture.Size = new System.Drawing.Size(256, 278);
            this.pbPreviewPicture.TabIndex = 2;
            this.pbPreviewPicture.TabStop = false;
            this.pbPreviewPicture.Click += new System.EventHandler(this.pbPreviewPicture_Click);
            // 
            // VignetteNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pictureBoxHandle);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pbPreviewPicture);
            this.MinimumSize = new System.Drawing.Size(266, 288);
            this.Name = "VignetteNV";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(266, 288);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHandle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelName;
        protected System.Windows.Forms.Label labelDate;
        protected internal System.Windows.Forms.PictureBox pbPreviewPicture;
        protected internal System.Windows.Forms.PictureBox pictureBoxHandle;
    }
}
