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
        private void InitializeComponent()
        {
            this.PhotoVignette = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoVignette)).BeginInit();
            this.SuspendLayout();
            // 
            // PhotoVignette
            // 
            this.PhotoVignette.Location = new System.Drawing.Point(3, 3);
            this.PhotoVignette.Name = "PhotoVignette";
            this.PhotoVignette.Size = new System.Drawing.Size(240, 245);
            this.PhotoVignette.TabIndex = 0;
            this.PhotoVignette.TabStop = false;
            this.PhotoVignette.MouseLeave += new System.EventHandler(this.PhotoVignette_MouseLeave);
            this.PhotoVignette.MouseHover += new System.EventHandler(this.PhotoVignette_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(24, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Vignette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PhotoVignette);
            this.Name = "Vignette";
            this.Size = new System.Drawing.Size(248, 251);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoVignette)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PhotoVignette;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
