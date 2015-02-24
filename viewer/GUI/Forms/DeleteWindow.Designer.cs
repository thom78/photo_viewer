namespace viewer
{
    partial class DeleteWindow
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
            this.but_ok = new System.Windows.Forms.Button();
            this.but_ko = new System.Windows.Forms.Button();
            this.textlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(46, 48);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(75, 23);
            this.but_ok.TabIndex = 0;
            this.but_ok.Text = "Ok";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // but_ko
            // 
            this.but_ko.Location = new System.Drawing.Point(127, 48);
            this.but_ko.Name = "but_ko";
            this.but_ko.Size = new System.Drawing.Size(75, 23);
            this.but_ko.TabIndex = 1;
            this.but_ko.Text = "Annuler";
            this.but_ko.UseVisualStyleBackColor = true;
            this.but_ko.Click += new System.EventHandler(this.but_ko_Click);
            // 
            // textlabel
            // 
            this.textlabel.AutoSize = true;
            this.textlabel.Location = new System.Drawing.Point(12, 13);
            this.textlabel.Name = "textlabel";
            this.textlabel.Size = new System.Drawing.Size(35, 13);
            this.textlabel.TabIndex = 2;
            this.textlabel.Text = "label1";
            // 
            // DeleteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 83);
            this.Controls.Add(this.textlabel);
            this.Controls.Add(this.but_ko);
            this.Controls.Add(this.but_ok);
            this.Name = "DeleteWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Avertissement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.Button but_ko;
        private System.Windows.Forms.Label textlabel;
    }
}