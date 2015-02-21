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
        private int cpt = 0;
        private int album_length = 0;
        private int interrupteur = 1;
        
        public Diapo(Album alb)
        {
            InitializeComponent();
            this.albDisplayedAlbum = alb;
            
            

            // détermination de la taille de l'album
            foreach (Picture t in albDisplayedAlbum.Pictures)
            {
                album_length++;
            }
            // test présence de photos dans l'album 
            if (album_length == 0)
            {
                System.Windows.Forms.MessageBox.Show("My message here");
                interrupteur = 0;
            }
        } 
           // timer
           private void timer1_Tick(object sender, EventArgs e)
            {
                if (interrupteur == 1)
                {
                    cpt++;
                    //réinitialisation du diapo
                    if (album_length == cpt)
                    {
                        cpt = 0;
                    }
                    //affichage de l'image
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image = albDisplayedAlbum.Pictures[cpt].Image;
                    }
                }
            }
            
        // affichage de la première image
        private void Diapo_Load(object sender, EventArgs e)
        {
            if (interrupteur == 1)
            {
                pictureBox1.Image = albDisplayedAlbum.Pictures[0].Image;
            }
        }

        //gestion du bouton suivante
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (interrupteur == 1)
            {
                //blocage du timer, chargement de la photo suivante
                timer1.Enabled = false;
                cpt++;

                //réinitialisation du diapo
                if (album_length == cpt)
                {
                    cpt = 0;
                }

                //affichage de l'image
                if (albDisplayedAlbum.Pictures.Count > 0)
                {
                    pictureBox1.Image = albDisplayedAlbum.Pictures[cpt].Image;
                }
                //on remet le timer en route
                timer1.Enabled = true;
            }
        }

        //gestion du bouton précédent
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (interrupteur == 1)
            {

                //même système mais dans l'autre sens
                timer1.Enabled = false;

                //réinitialisation du diapo
                if (cpt == 0)
                {
                    cpt = album_length;
                }

                cpt--;

                //affichage de l'image
                if (albDisplayedAlbum.Pictures.Count > 0)
                {
                    pictureBox1.Image = albDisplayedAlbum.Pictures[cpt].Image;
                }
                timer1.Enabled = true;
            }
        }
        // Gestion des flèches droite et gauche

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
                bool ret = true;
               
                switch (keyData)
                {
                    case Keys.Right:
                        {
                            if (interrupteur == 1)
                            {
                                cpt++;

                                //réinitialisation du diapo
                                if (album_length == cpt)
                                {
                                    cpt = 0;
                                }

                                //affichage de l'image
                                pictureBox1.Image = albDisplayedAlbum.Pictures[cpt].Image;
                            }
                        }
                        break;
                    case Keys.Left:
                        {
                            if (interrupteur == 1)
                            {
                                //réinitialisation du diapo
                                if (cpt == 0)
                                {
                                    cpt = album_length;
                                }

                                cpt--;

                                //affichage de l'image
                                pictureBox1.Image = albDisplayedAlbum.Pictures[cpt].Image;
                            }
                        }
                        break;
                    case Keys.Up: break;
                    case Keys.Down: break;
                    default: ret = base.ProcessCmdKey(ref msg, keyData); break;
                }

                return ret;
            }
        
        
       
   
    }
}
