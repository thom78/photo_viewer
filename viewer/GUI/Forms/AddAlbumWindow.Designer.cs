﻿namespace viewer
{
    partial class AddAlbumWindow
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
            this.TitreBox = new System.Windows.Forms.TextBox();
            this.SousTitreBox = new System.Windows.Forms.TextBox();
            this.but_ok = new System.Windows.Forms.Button();
            this.but_ko = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitreBox
            // 
            this.TitreBox.Location = new System.Drawing.Point(79, 12);
            this.TitreBox.Name = "TitreBox";
            this.TitreBox.Size = new System.Drawing.Size(156, 20);
            this.TitreBox.TabIndex = 0;
            this.TitreBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SousTitreBox
            // 
            this.SousTitreBox.Location = new System.Drawing.Point(79, 39);
            this.SousTitreBox.Name = "SousTitreBox";
            this.SousTitreBox.Size = new System.Drawing.Size(156, 20);
            this.SousTitreBox.TabIndex = 1;
            this.SousTitreBox.TextChanged += new System.EventHandler(this.SousTitreBox_TextChanged);
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(12, 92);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(75, 23);
            this.but_ok.TabIndex = 3;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // but_ko
            // 
            this.but_ko.Location = new System.Drawing.Point(94, 91);
            this.but_ko.Name = "but_ko";
            this.but_ko.Size = new System.Drawing.Size(75, 23);
            this.but_ko.TabIndex = 4;
            this.but_ko.Text = "Annuler";
            this.but_ko.UseVisualStyleBackColor = true;
            this.but_ko.Click += new System.EventHandler(this.KO_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sous-Titre";
            // 
            // AddAlbumWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 124);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_ko);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.SousTitreBox);
            this.Controls.Add(this.TitreBox);
            this.Name = "AddAlbumWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un Album";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitreBox;
        private System.Windows.Forms.TextBox SousTitreBox;
        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.Button but_ko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}