using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewer
{
    public partial class Vignette_alb : Vignette
    {
        //definition de lalbum de la vignette
        public Album Alb;
        public event EventHandler clickOnAlbum;
 
        public Vignette_alb(Album alb)
        {
            Alb = alb;
                //la vignette de lalbum correspond a la premiere photo de cet album (peut etre modifié)
                if ((Alb != null) && (Alb.Pictures.Count > 0))
                {
                    Pic = Alb.Pictures[0];
                    PhotoVignette.Image = Pic.Image;
                    PhotoVignette.SizeMode = PictureBoxSizeMode.Zoom;
                    PhotoVignette.Size = new Size(250, 250);
                    InfoBox.Visible = false;
                }
            else
            {
               ///////JARRIVE PAS A METRE UNE PHOTO RESSOURCE
                PhotoVignette.SizeMode = PictureBoxSizeMode.Zoom;
                PhotoVignette.Size = new Size(250, 250);
                InfoBox.Visible = false;
            }
        }

        //set limage de la vignette
        public void Set_Image()
        {
            if ((Alb != null) && (Alb.Pictures.Count > 0))
            {
                Pic = Alb.Pictures[0];
                PhotoVignette.Image = Pic.Image;
                PhotoVignette.SizeMode = PictureBoxSizeMode.Zoom;
                PhotoVignette.Size = new Size(250, 250);
            }
        }

        protected override void PhotoVignette_MouseEnter(object sender, EventArgs e)
        {
            //base.PhotoVignette_MouseEnter(sender, e);
            InfoBox.Visible = true;
            info1.Text = Alb.Title;
            info2.Text = Alb.SubTitle;
            info3.Text = Alb.Date;
        }
        protected override void PhotoVignette_Click(object sender, EventArgs e)
        {
            //On appelle la méthode qui créé un évènement
            VignetteWasClicked(null);            
        }

        protected virtual void VignetteWasClicked(EventArgs e)
        {
            //L'évènement est créé et envoyé aux objets abonnés
            EventHandler eh = clickOnAlbum;
            if (eh != null)
            {
                eh(this, e);
            }
        }
    }
}
