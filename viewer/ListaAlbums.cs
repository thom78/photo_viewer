using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///**********************************************************************************************************************************************************
/// NB: Le premier album en haut a gauche sera toujours l'album "Pellicule" dans lequel on trouve l'integralité des photos 
/// --->>> a chaque fois quon importe des photos, ne pas oublier de les ajouter à lalbum "pellicule"!
/// a faire: creation album, ajout de photos a album
/// *********************************************************************************************************************************************************

namespace viewer
{
    public partial class ListaAlbums : Form
    {
        public ListaAlbums()
        {
            InitializeComponent();

            //creation des images a partir de la picture box, et ajout dans lalbum pellicule
            foreach (Image t in PhotosDeCouvertureAlbum.Images)
            {
                new Picture(t);
            }

            /// Affichage d'images en grid
            AlbumGrid.FlowDirection = FlowDirection.LeftToRight;
            AlbumGrid.AutoScroll = true;
            foreach (Picture t in Album.Pellicule.Pictures)
            {
                PictureBox a = new PictureBox();
                a.Image = t.Image;
                a.SizeMode = PictureBoxSizeMode.Zoom;
                a.Size = new Size(250, 250);
                AlbumGrid.Controls.Add(a);
            }
        }
        

        private void createAlbumButton_Click(object sender, EventArgs e)
        {
            AddAlbum new_album = new AddAlbum();
            new_album.ShowDialog();
        }

        private void but_import_Click(object sender, EventArgs e)
        {
            /// Ajoute la photo importée a la pellicule et laffiche dans la picturebox       
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Picture pic = new Picture(System.Drawing.Image.FromFile(openFileDialog1.FileName));
                PictureBox pbx = new PictureBox();
                pbx.Image = pic.Image;
                pbx.SizeMode = PictureBoxSizeMode.Zoom;
                pbx.Size = new Size(250, 250);
                AlbumGrid.Controls.Add(pbx);
            }
        }

    }
}
