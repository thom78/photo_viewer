namespace viewer
{
    partial class Vignette_test
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Note1 = new System.Windows.Forms.RadioButton();
            this.Note2 = new System.Windows.Forms.RadioButton();
            this.Note3 = new System.Windows.Forms.RadioButton();
            this.Note4 = new System.Windows.Forms.RadioButton();
            this.Note5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Note5);
            this.panel1.Controls.Add(this.Note4);
            this.panel1.Controls.Add(this.Note3);
            this.panel1.Controls.Add(this.Note2);
            this.panel1.Controls.Add(this.Note1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sous-titre";
            // 
            // Note1
            // 
            this.Note1.AutoSize = true;
            this.Note1.Location = new System.Drawing.Point(70, 38);
            this.Note1.Name = "Note1";
            this.Note1.Size = new System.Drawing.Size(14, 13);
            this.Note1.TabIndex = 2;
            this.Note1.TabStop = true;
            this.Note1.UseVisualStyleBackColor = true;
            // 
            // Note2
            // 
            this.Note2.AutoSize = true;
            this.Note2.Location = new System.Drawing.Point(90, 38);
            this.Note2.Name = "Note2";
            this.Note2.Size = new System.Drawing.Size(14, 13);
            this.Note2.TabIndex = 3;
            this.Note2.TabStop = true;
            this.Note2.UseVisualStyleBackColor = true;
            // 
            // Note3
            // 
            this.Note3.AutoSize = true;
            this.Note3.Location = new System.Drawing.Point(110, 38);
            this.Note3.Name = "Note3";
            this.Note3.Size = new System.Drawing.Size(14, 13);
            this.Note3.TabIndex = 4;
            this.Note3.TabStop = true;
            this.Note3.UseVisualStyleBackColor = true;
            // 
            // Note4
            // 
            this.Note4.AutoSize = true;
            this.Note4.Location = new System.Drawing.Point(130, 38);
            this.Note4.Name = "Note4";
            this.Note4.Size = new System.Drawing.Size(14, 13);
            this.Note4.TabIndex = 5;
            this.Note4.TabStop = true;
            this.Note4.UseVisualStyleBackColor = true;
            // 
            // Note5
            // 
            this.Note5.AutoSize = true;
            this.Note5.Location = new System.Drawing.Point(150, 38);
            this.Note5.Name = "Note5";
            this.Note5.Size = new System.Drawing.Size(14, 13);
            this.Note5.TabIndex = 6;
            this.Note5.TabStop = true;
            this.Note5.UseVisualStyleBackColor = true;
            // 
            // Vignette_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "Vignette_test";
            this.Size = new System.Drawing.Size(250, 250);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Note5;
        private System.Windows.Forms.RadioButton Note4;
        private System.Windows.Forms.RadioButton Note3;
        private System.Windows.Forms.RadioButton Note2;
        private System.Windows.Forms.RadioButton Note1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
