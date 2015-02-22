namespace viewer.GUI.UserControls
{
    partial class VignetteNVAlbum
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param strName="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelNumPhotos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Location = new System.Drawing.Point(7, 21);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(55, 13);
            this.labelSubtitle.TabIndex = 2;
            this.labelSubtitle.Text = "Sous-Titre";
            // 
            // labelNumPhotos
            // 
            this.labelNumPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNumPhotos.AutoSize = true;
            this.labelNumPhotos.Location = new System.Drawing.Point(7, 243);
            this.labelNumPhotos.Name = "labelNumPhotos";
            this.labelNumPhotos.Size = new System.Drawing.Size(50, 13);
            this.labelNumPhotos.TabIndex = 3;
            this.labelNumPhotos.Text = "n Images";
            // 
            // VignetteNVAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.labelNumPhotos);
            this.Controls.Add(this.labelSubtitle);
            this.Name = "VignetteNVAlbum";
            this.Controls.SetChildIndex(this.pbPreviewPicture, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.labelDate, 0);
            this.Controls.SetChildIndex(this.labelSubtitle, 0);
            this.Controls.SetChildIndex(this.labelNumPhotos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelNumPhotos;
    }
}
