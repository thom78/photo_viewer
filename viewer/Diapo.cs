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
    public partial class Diapo : Form
    {
        public Diapo()
        {
            InitializeComponent();
            // détermination de la taille de l'album
            foreach (Picture t in Album.Pellicule.Pictures)
            {
                j++;
            }
        }


        int i = 0;
        int j = 0;
              
     
           private void timer1_Tick(object sender, EventArgs e)
            {


               i++;

                //réinitialisation du compteur
                if (j == i)
                {
                    i = 0;
                }

                //affichage de l'image
                pictureBox1.Image = Album.Pellicule.Pictures[i].Image;

            }
            
        
             //tableau d'images

        
        
        private void Diapo_Load(object sender, EventArgs e)
        {
            //affichage de la 1ere image.
            pictureBox1.Image = Album.Pellicule.Pictures[0].Image;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //blocage du timer, chargement de la photo suivante
            timer1.Enabled = false;

            
            i++;

            //réinitialisation du compteur
           if (j == i)
            {
                i = 0;
            }

           //affichage de l'image
           pictureBox1.Image = Album.Pellicule.Pictures[i].Image;

            //on remet le timer en route
            timer1.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //même système mais dans l'autre sens


            timer1.Enabled = false;

            //réinitialisation du compteur
            if (i == 0)
            {
                i = j;
            }

            i--;

            //affichage de l'image
            pictureBox1.Image = Album.Pellicule.Pictures[i].Image;

            timer1.Enabled = true;
        }
   
    }
}
