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
            /// Affichage d'images en grid

            AlbumGrid.FlowDirection = FlowDirection.LeftToRight;
            AlbumGrid.AutoScroll = true;
            for (int j = 0; j < 40; j++)
            {
                foreach (Image t in PhotosDeCouvertureAlbum.Images)
                {
                    PictureBox a = new PictureBox();
                    a.Image = t;
                    a.SizeMode = PictureBoxSizeMode.Zoom;
                    a.Size = new Size(250, 250);
                    AlbumGrid.Controls.Add(a);
                }
            }
        }
    }
}
