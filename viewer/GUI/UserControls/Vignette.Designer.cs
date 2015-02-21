namespace viewer
{
    partial class Vignette
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
        protected void InitializeComponent()
        {
            this.PhotoVignette = new System.Windows.Forms.PictureBox();
            this.InfoBox = new System.Windows.Forms.GroupBox();
            this.rate5 = new System.Windows.Forms.RadioButton();
            this.rate4 = new System.Windows.Forms.RadioButton();
            this.rate3 = new System.Windows.Forms.RadioButton();
            this.rate2 = new System.Windows.Forms.RadioButton();
            this.rate1 = new System.Windows.Forms.RadioButton();
            this.info3 = new System.Windows.Forms.Label();
            this.info2 = new System.Windows.Forms.Label();
            this.info1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoVignette)).BeginInit();
            this.InfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhotoVignette
            // 
            this.PhotoVignette.Location = new System.Drawing.Point(8, 7);
            this.PhotoVignette.Name = "PhotoVignette";
            this.PhotoVignette.Size = new System.Drawing.Size(249, 245);
            this.PhotoVignette.TabIndex = 0;
            this.PhotoVignette.TabStop = false;
            this.PhotoVignette.Click += new System.EventHandler(this.PhotoVignette_Click);
            this.PhotoVignette.MouseEnter += new System.EventHandler(this.PhotoVignette_MouseEnter);
            this.PhotoVignette.MouseLeave += new System.EventHandler(this.PhotoVignette_MouseLeave);
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.Gainsboro;
            this.InfoBox.Controls.Add(this.rate5);
            this.InfoBox.Controls.Add(this.rate4);
            this.InfoBox.Controls.Add(this.rate3);
            this.InfoBox.Controls.Add(this.rate2);
            this.InfoBox.Controls.Add(this.rate1);
            this.InfoBox.Controls.Add(this.info3);
            this.InfoBox.Controls.Add(this.info2);
            this.InfoBox.Controls.Add(this.info1);
            this.InfoBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoBox.Location = new System.Drawing.Point(0, 155);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(266, 101);
            this.InfoBox.TabIndex = 1;
            this.InfoBox.TabStop = false;
            // 
            // rate5
            // 
            this.rate5.AutoSize = true;
            this.rate5.Location = new System.Drawing.Point(170, 66);
            this.rate5.Name = "rate5";
            this.rate5.Size = new System.Drawing.Size(14, 13);
            this.rate5.TabIndex = 3;
            this.rate5.TabStop = true;
            this.rate5.UseVisualStyleBackColor = true;
            // 
            // rate4
            // 
            this.rate4.AutoSize = true;
            this.rate4.Location = new System.Drawing.Point(150, 66);
            this.rate4.Name = "rate4";
            this.rate4.Size = new System.Drawing.Size(14, 13);
            this.rate4.TabIndex = 3;
            this.rate4.TabStop = true;
            this.rate4.UseVisualStyleBackColor = true;
            // 
            // rate3
            // 
            this.rate3.AutoSize = true;
            this.rate3.Location = new System.Drawing.Point(130, 66);
            this.rate3.Name = "rate3";
            this.rate3.Size = new System.Drawing.Size(14, 13);
            this.rate3.TabIndex = 3;
            this.rate3.TabStop = true;
            this.rate3.UseVisualStyleBackColor = true;
            // 
            // rate2
            // 
            this.rate2.AutoSize = true;
            this.rate2.Location = new System.Drawing.Point(110, 66);
            this.rate2.Name = "rate2";
            this.rate2.Size = new System.Drawing.Size(14, 13);
            this.rate2.TabIndex = 3;
            this.rate2.TabStop = true;
            this.rate2.UseVisualStyleBackColor = true;
            // 
            // rate1
            // 
            this.rate1.AutoSize = true;
            this.rate1.Location = new System.Drawing.Point(90, 66);
            this.rate1.Name = "rate1";
            this.rate1.Size = new System.Drawing.Size(14, 13);
            this.rate1.TabIndex = 3;
            this.rate1.TabStop = true;
            this.rate1.UseVisualStyleBackColor = true;
            // 
            // info3
            // 
            this.info3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.info3.AutoSize = true;
            this.info3.Location = new System.Drawing.Point(105, 33);
            this.info3.Name = "info3";
            this.info3.Size = new System.Drawing.Size(35, 13);
            this.info3.TabIndex = 2;
            this.info3.Text = "label2";
            // 
            // info2
            // 
            this.info2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.info2.AutoSize = true;
            this.info2.Location = new System.Drawing.Point(106, 50);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(35, 13);
            this.info2.TabIndex = 1;
            this.info2.Text = "label1";
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Location = new System.Drawing.Point(106, 16);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(35, 13);
            this.info1.TabIndex = 0;
            this.info1.Text = "label1";
            // 
            // Vignette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.PhotoVignette);
            this.Name = "Vignette";
            this.Size = new System.Drawing.Size(266, 256);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoVignette)).EndInit();
            this.InfoBox.ResumeLayout(false);
            this.InfoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox PhotoVignette;
        protected System.Windows.Forms.GroupBox InfoBox;
        private System.Windows.Forms.RadioButton rate5;
        private System.Windows.Forms.RadioButton rate4;
        private System.Windows.Forms.RadioButton rate3;
        private System.Windows.Forms.RadioButton rate2;
        private System.Windows.Forms.RadioButton rate1;
        protected System.Windows.Forms.Label info3;
        protected System.Windows.Forms.Label info2;
        protected System.Windows.Forms.Label info1;
    }
}
