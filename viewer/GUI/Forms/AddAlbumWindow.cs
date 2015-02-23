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
    public partial class AddAlbumWindow : Form
    {
        public Album created_album;
        public Album album_to_rename = null;

        public AddAlbumWindow()
        {
            InitializeComponent();
            but_ok.Enabled = false;
        }

        //constructeur appelé lorsequon renomme lalbum
        public AddAlbumWindow(Album alb_to_rename)
        {
            InitializeComponent();
            but_ok.Enabled = false;
            this.Text = "Renommer l'album";
            album_to_rename = alb_to_rename;
        }

        private void KO_but_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TitreBox.Text.Trim().Length > 0) 
            {
                but_ok.Enabled = true;
            }
            else
            {
                but_ok.Enabled = false;
            }
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            if(album_to_rename != null)
            {
                if (TitreBox.Text.Trim().Length > 0)
                {
                    album_to_rename.Title = TitreBox.Text.ToString();
                }
                if (SousTitreBox.Text.Trim().Length > 0)
                {
                    album_to_rename.SubTitle = SousTitreBox.Text.ToString();
                }
            }
            else
            {
                //creer album avec constructeur different en fonction de ce qui a été rempli
                created_album = new Album(TitreBox.Text.ToString(), SousTitreBox.Text.ToString(), DateTime.Now.ToShortDateString());
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SousTitreBox_TextChanged(object sender, EventArgs e)
        {
            if (album_to_rename != null && SousTitreBox.Text.Trim().Length > 0) 
            {
                but_ok.Enabled = true;
            }
            else
            {
                but_ok.Enabled = false;
            }
        }
    }
}
