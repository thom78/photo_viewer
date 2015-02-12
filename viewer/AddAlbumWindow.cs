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

        public AddAlbumWindow()
        {
            InitializeComponent();
            but_ok.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KO_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
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
            //creer album avec constructeur different en fonction de ce qui a été rempli
            created_album = new Album(textBox1.Text.ToString(), textBox2.Text.ToString(), DateTime.Now.ToShortDateString());

            // Par defaut ajouter la premiere photo de la pellicule comme premiere photo de lalbum !!!!!!!!!A CHANGER!!!!!!!!
            if (Program.Pellicule.Pictures.Count > 0) 
            {
            created_album.Pictures.Add(Program.Pellicule.Pictures[0]);
            }
            this.Close();
        }
    }
}
