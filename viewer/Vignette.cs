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
        //definition de limage de la vignette
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
            groupBox1.Visible = false;
        }

        public Vignette(Album alb)
        {
            type = ALBUM;
            Alb = alb;
            //la vignette de lalbum correspond a la premiere photo de cet album (peut etre modifié)
            if ((Alb!=null)&&(Alb.Pictures.Count > 0))
            {
                Pic = Alb.Pictures[0];
                InitializeComponent();
                PhotoVignette.Image = Pic.Image;
                PhotoVignette.SizeMode = PictureBoxSizeMode.Zoom;
                PhotoVignette.Size = new Size(250, 250);
                groupBox1.Visible = false;
            }
        }
     
        private void PhotoVignette_MouseHover(object sender, EventArgs e)
        {
            //en fonction du type de la vignette on affiche soit les infos de lalbum, soit les infos de limage
            if(type==IMAGE)
            {
                groupBox1.Visible = true;
                MessageBox.Show(Pic.Name);
            }
            else
            {
                groupBox1.Visible = true;
                MessageBox.Show(Alb.Title);
            }
            
        }

        private void PhotoVignette_MouseLeave(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }      
    }
}
