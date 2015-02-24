using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewer
{
    public partial class RenamePictureWindow : Form
    {
        #region Attributs
        public Picture picture_to_rename;
        #endregion Attributs

        #region Constructeurs
        public RenamePictureWindow(Picture pic_to_rename)
        {
            InitializeComponent();
            but_ok.Enabled = false;
            picture_to_rename = pic_to_rename;
        }
        #endregion Constructeurs

        #region Interface
        #region autoriser appui sur bouton ok
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            if (NameBox.Text.Trim().Length > 0)
            {
                but_ok.Enabled = true;
            }
            else
            {
                but_ok.Enabled = false;
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (commentBox.Text.Trim().Length > 0)
            {
                but_ok.Enabled = true;
            }
            else
            {
                but_ok.Enabled = false;
            }
        }
        #endregion autoriser appui sur bouton ok

        #region Valider/annuler
        private void butOk_Click(object sender, EventArgs e)
        {
            if (NameBox.Text.Trim().Length > 0)
            {
                picture_to_rename.Name = NameBox.Text.ToString();
            }
            if (commentBox.Text.Trim().Length > 0)
            {
                picture_to_rename.Comment = commentBox.Text.ToString();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void butKO_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion Valider/annuler
        #endregion Interface
    }
}
