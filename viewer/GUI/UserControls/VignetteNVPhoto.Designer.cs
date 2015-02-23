namespace viewer.GUI.UserControls
{
    partial class VignetteNVPhoto
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rbNote5 = new System.Windows.Forms.RadioButton();
            this.rbNote4 = new System.Windows.Forms.RadioButton();
            this.rbNote3 = new System.Windows.Forms.RadioButton();
            this.rbNote2 = new System.Windows.Forms.RadioButton();
            this.rbNote1 = new System.Windows.Forms.RadioButton();
            this.toolTipPicComment = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHandle)).BeginInit();
            this.SuspendLayout();
            // 
            // rbNote5
            // 
            this.rbNote5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNote5.AutoSize = true;
            this.rbNote5.Location = new System.Drawing.Point(239, 3);
            this.rbNote5.Name = "rbNote5";
            this.rbNote5.Size = new System.Drawing.Size(14, 13);
            this.rbNote5.TabIndex = 11;
            this.rbNote5.UseVisualStyleBackColor = true;
            this.rbNote5.CheckedChanged += new System.EventHandler(this.rbNote5_CheckedChanged);
            // 
            // rbNote4
            // 
            this.rbNote4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNote4.AutoSize = true;
            this.rbNote4.Location = new System.Drawing.Point(219, 3);
            this.rbNote4.Name = "rbNote4";
            this.rbNote4.Size = new System.Drawing.Size(14, 13);
            this.rbNote4.TabIndex = 10;
            this.rbNote4.UseVisualStyleBackColor = true;
            this.rbNote4.CheckedChanged += new System.EventHandler(this.rbNote4_CheckedChanged);
            // 
            // rbNote3
            // 
            this.rbNote3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNote3.AutoSize = true;
            this.rbNote3.Location = new System.Drawing.Point(199, 3);
            this.rbNote3.Name = "rbNote3";
            this.rbNote3.Size = new System.Drawing.Size(14, 13);
            this.rbNote3.TabIndex = 9;
            this.rbNote3.UseVisualStyleBackColor = true;
            this.rbNote3.CheckedChanged += new System.EventHandler(this.rbNote3_CheckedChanged);
            // 
            // rbNote2
            // 
            this.rbNote2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNote2.AutoSize = true;
            this.rbNote2.Location = new System.Drawing.Point(179, 3);
            this.rbNote2.Name = "rbNote2";
            this.rbNote2.Size = new System.Drawing.Size(14, 13);
            this.rbNote2.TabIndex = 8;
            this.rbNote2.UseVisualStyleBackColor = true;
            this.rbNote2.CheckedChanged += new System.EventHandler(this.rbNote2_CheckedChanged);
            // 
            // rbNote1
            // 
            this.rbNote1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNote1.AutoSize = true;
            this.rbNote1.Checked = true;
            this.rbNote1.Location = new System.Drawing.Point(159, 3);
            this.rbNote1.Name = "rbNote1";
            this.rbNote1.Size = new System.Drawing.Size(14, 13);
            this.rbNote1.TabIndex = 7;
            this.rbNote1.TabStop = true;
            this.rbNote1.UseVisualStyleBackColor = true;
            this.rbNote1.CheckedChanged += new System.EventHandler(this.rbNote1_CheckedChanged);
            // 
            // VignetteNVPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.rbNote5);
            this.Controls.Add(this.rbNote4);
            this.Controls.Add(this.rbNote3);
            this.Controls.Add(this.rbNote2);
            this.Controls.Add(this.rbNote1);
            this.Name = "VignetteNVPhoto";
            this.Controls.SetChildIndex(this.pbPreviewPicture, 0);
            this.Controls.SetChildIndex(this.labelName, 0);
            this.Controls.SetChildIndex(this.labelDate, 0);
            this.Controls.SetChildIndex(this.pictureBoxHandle, 0);
            this.Controls.SetChildIndex(this.rbNote1, 0);
            this.Controls.SetChildIndex(this.rbNote2, 0);
            this.Controls.SetChildIndex(this.rbNote3, 0);
            this.Controls.SetChildIndex(this.rbNote4, 0);
            this.Controls.SetChildIndex(this.rbNote5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHandle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNote5;
        private System.Windows.Forms.RadioButton rbNote4;
        private System.Windows.Forms.RadioButton rbNote3;
        private System.Windows.Forms.RadioButton rbNote2;
        private System.Windows.Forms.RadioButton rbNote1;
        private System.Windows.Forms.ToolTip toolTipPicComment;
    }
}
