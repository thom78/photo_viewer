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
        public Album linkedAlb;
        public event EventHandler clickOnAlbum;
 
        public Vignette_alb(Album alb)
        {
            linkedAlb = alb;
            //la vignette de lalbum correspond a la premiere photo de cet album (peut etre modifié)
            this.refreshPreviewPicture();
        }

        public void refreshPreviewPicture()
        {
            if ((linkedAlb != null) && (linkedAlb.Pictures.Count > 0))
            {
                Pic = linkedAlb.Pictures[0];
                PhotoVignette.Image = Pic.Image;
                PhotoVignette.SizeMode = PictureBoxSizeMode.Zoom;
                PhotoVignette.Size = new Size(250, 250);
                InfoBox.Visible = false;
            }
        }

        protected override void PhotoVignette_MouseEnter(object sender, EventArgs e)
        {
            //base.PhotoVignette_MouseEnter(sender, e);
            InfoBox.Visible = true;
            info1.Text = linkedAlb.Title;
            info2.Text = linkedAlb.SubTitle;
            info3.Text = linkedAlb.Date;
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
