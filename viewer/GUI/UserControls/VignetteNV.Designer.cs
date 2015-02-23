﻿namespace viewer
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
            this.pbPreviewPicture = new System.Windows.Forms.PictureBox();
            this.statustripDragHandle = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.Control;
            this.labelName.Location = new System.Drawing.Point(9, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(28, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Titre";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.SystemColors.Control;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(8, 264);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(73, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "JJ/MM/AAAA";
            // 
            // pbPreviewPicture
            // 
            this.pbPreviewPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPreviewPicture.Image = global::viewer.Properties.Resources.empty;
            this.pbPreviewPicture.Location = new System.Drawing.Point(5, 5);
            this.pbPreviewPicture.Name = "pbPreviewPicture";
            this.pbPreviewPicture.Size = new System.Drawing.Size(256, 256);
            this.pbPreviewPicture.TabIndex = 2;
            this.pbPreviewPicture.TabStop = false;
            this.pbPreviewPicture.Click += new System.EventHandler(this.pbPreviewPicture_Click);
            // 
            // statustripDragHandle
            // 
            this.statustripDragHandle.BackColor = System.Drawing.Color.Transparent;
            this.statustripDragHandle.Location = new System.Drawing.Point(5, 261);
            this.statustripDragHandle.Name = "statustripDragHandle";
            this.statustripDragHandle.Size = new System.Drawing.Size(256, 22);
            this.statustripDragHandle.TabIndex = 3;
            this.statustripDragHandle.DragOver += new System.Windows.Forms.DragEventHandler(this.VignetteNV_DragOver);
            this.statustripDragHandle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VignetteNV_MouseDown);
            // 
            // VignetteNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pbPreviewPicture);
            this.Controls.Add(this.statustripDragHandle);
            this.MinimumSize = new System.Drawing.Size(259, 259);
            this.Name = "VignetteNV";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(266, 288);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelName;
        protected System.Windows.Forms.Label labelDate;
        protected System.Windows.Forms.PictureBox pbPreviewPicture;
        private System.Windows.Forms.StatusStrip statustripDragHandle;
    }
}
