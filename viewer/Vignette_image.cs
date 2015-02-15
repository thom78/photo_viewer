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
    public partial class Vignette_image : Vignette
    {
        public Vignette_image(Picture pic) 
        {
            Pic = pic;
            PhotoVignette.Image = Pic.Image;
            PhotoVignette.SizeMode = PictureBoxSizeMode.Zoom;
            PhotoVignette.Size = new Size(250, 250);
            InfoBox.Visible = false;
        }

        protected override void PhotoVignette_MouseEnter(object sender, EventArgs e)
        {
            base.PhotoVignette_MouseEnter(sender, e);
            InfoBox.Visible = true;
            info1.Text = Pic.Name;
            info2.Text = Pic.Date;
            info3.Text = " ";
            // MessageBox.Show(Pic.Name);
        }

    }
}
