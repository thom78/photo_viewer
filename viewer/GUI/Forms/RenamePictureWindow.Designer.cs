namespace viewer
{
    partial class RenamePictureWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.commentBox = new System.Windows.Forms.RichTextBox();
            this.but_ok = new System.Windows.Forms.Button();
            this.but_ko = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(95, 6);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(128, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Commentaire";
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(95, 32);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(128, 49);
            this.commentBox.TabIndex = 4;
            this.commentBox.Text = "";
            this.commentBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(13, 87);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(75, 23);
            this.but_ok.TabIndex = 5;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.butOk_Click);
            // 
            // but_ko
            // 
            this.but_ko.Location = new System.Drawing.Point(95, 87);
            this.but_ko.Name = "but_ko";
            this.but_ko.Size = new System.Drawing.Size(75, 23);
            this.but_ko.TabIndex = 6;
            this.but_ko.Text = "Annuler";
            this.but_ko.UseVisualStyleBackColor = true;
            this.but_ko.Click += new System.EventHandler(this.butKO_Click);
            // 
            // RenamePictureWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 121);
            this.Controls.Add(this.but_ko);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Name = "RenamePictureWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Renommer la photo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox commentBox;
        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.Button but_ko;
    }
}