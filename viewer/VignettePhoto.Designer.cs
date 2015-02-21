namespace viewer
{
    partial class VignettePhoto
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.labelTitrePhoto = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.rbNote1 = new System.Windows.Forms.RadioButton();
            this.rbNote2 = new System.Windows.Forms.RadioButton();
            this.rbNote3 = new System.Windows.Forms.RadioButton();
            this.rbNote4 = new System.Windows.Forms.RadioButton();
            this.rbNote5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pbPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPhoto.Location = new System.Drawing.Point(0, 0);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(256, 256);
            this.pbPhoto.TabIndex = 0;
            this.pbPhoto.TabStop = false;
            // 
            // labelTitrePhoto
            // 
            this.labelTitrePhoto.AutoSize = true;
            this.labelTitrePhoto.Location = new System.Drawing.Point(3, 0);
            this.labelTitrePhoto.Name = "labelTitrePhoto";
            this.labelTitrePhoto.Size = new System.Drawing.Size(28, 13);
            this.labelTitrePhoto.TabIndex = 0;
            this.labelTitrePhoto.Text = "Titre";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(180, 243);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(73, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "JJ/MM/AAAA";
            // 
            // rbNote1
            // 
            this.rbNote1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNote1.AutoSize = true;
            this.rbNote1.Checked = true;
            this.rbNote1.Location = new System.Drawing.Point(159, 3);
            this.rbNote1.Name = "rbNote1";
            this.rbNote1.Size = new System.Drawing.Size(14, 13);
            this.rbNote1.TabIndex = 2;
            this.rbNote1.TabStop = true;
            this.rbNote1.UseVisualStyleBackColor = true;
            this.rbNote1.CheckedChanged += new System.EventHandler(this.rbNote1_CheckedChanged);
            // 
            // rbNote2
            // 
            this.rbNote2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNote2.AutoSize = true;
            this.rbNote2.Location = new System.Drawing.Point(179, 3);
            this.rbNote2.Name = "rbNote2";
            this.rbNote2.Size = new System.Drawing.Size(14, 13);
            this.rbNote2.TabIndex = 3;
            this.rbNote2.UseVisualStyleBackColor = true;
            this.rbNote2.CheckedChanged += new System.EventHandler(this.rbNote2_CheckedChanged);
            // 
            // rbNote3
            // 
            this.rbNote3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNote3.AutoSize = true;
            this.rbNote3.Location = new System.Drawing.Point(199, 3);
            this.rbNote3.Name = "rbNote3";
            this.rbNote3.Size = new System.Drawing.Size(14, 13);
            this.rbNote3.TabIndex = 4;
            this.rbNote3.UseVisualStyleBackColor = true;
            this.rbNote3.CheckedChanged += new System.EventHandler(this.rbNote3_CheckedChanged);
            // 
            // rbNote4
            // 
            this.rbNote4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNote4.AutoSize = true;
            this.rbNote4.Location = new System.Drawing.Point(219, 3);
            this.rbNote4.Name = "rbNote4";
            this.rbNote4.Size = new System.Drawing.Size(14, 13);
            this.rbNote4.TabIndex = 5;
            this.rbNote4.UseVisualStyleBackColor = true;
            this.rbNote4.CheckedChanged += new System.EventHandler(this.rbNote4_CheckedChanged);
            // 
            // rbNote5
            // 
            this.rbNote5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNote5.AutoSize = true;
            this.rbNote5.Location = new System.Drawing.Point(239, 3);
            this.rbNote5.Name = "rbNote5";
            this.rbNote5.Size = new System.Drawing.Size(14, 13);
            this.rbNote5.TabIndex = 6;
            this.rbNote5.UseVisualStyleBackColor = true;
            this.rbNote5.CheckedChanged += new System.EventHandler(this.rbNote5_CheckedChanged);
            // 
            // Vignette_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.rbNote5);
            this.Controls.Add(this.rbNote4);
            this.Controls.Add(this.labelTitrePhoto);
            this.Controls.Add(this.rbNote3);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.rbNote2);
            this.Controls.Add(this.rbNote1);
            this.Controls.Add(this.pbPhoto);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(256, 256);
            this.Name = "Vignette_test";
            this.Size = new System.Drawing.Size(256, 256);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label labelTitrePhoto;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.RadioButton rbNote1;
        private System.Windows.Forms.RadioButton rbNote2;
        private System.Windows.Forms.RadioButton rbNote3;
        private System.Windows.Forms.RadioButton rbNote4;
        private System.Windows.Forms.RadioButton rbNote5;
    }
}
