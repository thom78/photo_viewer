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
        private Album albDisplayedAlbum;
        public Diapo(Album alb)
        {
            InitializeComponent();
            this.albDisplayedAlbum = alb;
            // détermination de la taille de l'album

            foreach (Picture t in albDisplayedAlbum.Pictures)
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
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image = albDisplayedAlbum.Pictures[i].Image;
                }
            }
            
        
        private void Diapo_Load(object sender, EventArgs e)
        {
            //affichage de la 1ere image.
            pictureBox1.Image = albDisplayedAlbum.Pictures[0].Image;
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
           if (albDisplayedAlbum.Pictures.Count > 0)
           {
               pictureBox1.Image = albDisplayedAlbum.Pictures[i].Image;
           }

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
            if (albDisplayedAlbum.Pictures.Count > 0)
            {
                pictureBox1.Image = albDisplayedAlbum.Pictures[i].Image;
            }
                timer1.Enabled = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool ret = true;
            switch (keyData)
                    {
                        case Keys.Right:
                            {
                                i++;

                                //réinitialisation du compteur
                                if (j == i)
                                {
                                    i = 0;
                                }

                                //affichage de l'image
                                pictureBox1.Image = albDisplayedAlbum.Pictures[i].Image;
                            }
                            break;
                        case Keys.Left:
                           {
                                //réinitialisation du compteur
                                if (i == 0)
                                {
                                    i = j;
                                }

                                i--;

                                //affichage de l'image
                                pictureBox1.Image = albDisplayedAlbum.Pictures[i].Image;
                            }
                            break;
                        case Keys.Up:  break;
                        case Keys.Down:  break;
                        default: ret = base.ProcessCmdKey(ref msg, keyData); break;
                    }

            return ret;
         }
        
       
   
    }
}
