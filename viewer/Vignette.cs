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
    public partial class Vignette : UserControl
    {
        //definition de limace de la vignette
        private Picture Pic;

        //definition de lalbum de la vignette
        private Album Alb;

        //definition des constantes
        public const Int16 IMAGE = 0;
        public const Int16 ALBUM = 1;

        //definition du type de vignette (album ou image)
        private Int16 type;

        public Vignette(Picture pic)
        {
            type = IMAGE;
            Pic=pic;
            InitializeComponent();
            PhotoVignette.Image = Pic.Image;
            PhotoVignette.SizeMode = PictureBoxSizeMode.Zoom;
            PhotoVignette.Size = new Size(250, 250);
            InfoBox.Visible = false;
        }

        public Vignette(Album alb)
        {
            type = ALBUM;
            Alb = alb;
            //la vignette de lalbum correspond a la premiere photo de cet album (peut etre modifié)
            Pic = Alb.Pictures[0];
            InitializeComponent();
            PhotoVignette.Image = Pic.Image;
            PhotoVignette.SizeMode = PictureBoxSizeMode.Zoom;
            PhotoVignette.Size = new Size(250, 250);
            InfoBox.Visible = false;
        }

        private void Vignette_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void Vignette_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void PhotoVignette_MouseEnter(object sender, EventArgs e)
        {
            //en fonction du type de la vignette on affiche soit les infos de lalbum, soit les infos de limage
            if (type == IMAGE)
            {
                InfoBox.Visible = true;
                info1.Text = Pic.Name;
                info2.Text = Pic.Date;
                info3.Text = " ";
                // MessageBox.Show(Pic.Name);
            }
            else
            {
                InfoBox.Visible = true;
                info1.Text = Alb.Title;
                info2.Text = Alb.SubTitle;
                info3.Text = Alb.Date;
            }
        }

        private void PhotoVignette_MouseLeave(object sender, EventArgs e)
        {
            if (!this.Bounds.Contains(PointToClient(MousePosition)))
            {
                InfoBox.Visible = false;
            }
        }
    }
}
