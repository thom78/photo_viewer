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
/// CREER UNE FONCTIN : AJOUT DE PHOTO DANS UNE GRID AU LIEU DE COPIER COLLER LE TEXTE TOUT LE TOUT LE TEMPS
/// supprimer albums, photos
/// *********************************************************************************************************************************************************

namespace viewer
{
    public partial class ListaAlbums : Form
    {
        //definition de constantes
        public const int ALBUM = 0;
        public const int IMAGE = 1;

        private void show_vignette(Picture pic)
        {
            Vignette vignet = new Vignette(pic);
            AllPhotosGrid.Controls.Add(vignet);
        }

        private void show_vignette(Album alb)
        {
            Vignette vignet = new Vignette(alb);
            AlbumGrid.Controls.Add(vignet);
        }

        public ListaAlbums()
        {
            InitializeComponent();

            //creation des images a partir de la picture box, et ajout dans lalbum pellicule
            foreach (Image t in PhotosDeCouvertureAlbum.Images)
            {
                new Picture(t);
            }

            /// Affichage d'images en grid
            AllPhotosGrid.FlowDirection = FlowDirection.LeftToRight;
            AllPhotosGrid.AutoScroll = true;
            foreach (Picture t in Album.Pellicule.Pictures)
            {
                show_vignette(t);
            }

            /// Affichage des albums
            AlbumGrid.FlowDirection = FlowDirection.LeftToRight;
            AlbumGrid.AutoScroll = true;
            foreach (Album t in Album.Albums)
            {
                show_vignette(t);
            }
        }
        

        private void createAlbumButton_Click(object sender, EventArgs e)
        {
            AddAlbum new_album = new AddAlbum();
            new_album.ShowDialog();
            // on cree une nouvelle image de lalbum grid pour afficher le nouvel album
            //on affiche la premiere photo de lalbum comme photo de couverture !!!!!!!!!!A CHA?GER!!!!!!!!!!!!!!!!!!!
            show_vignette(new_album.created_album);
        }

        private void but_import_Click(object sender, EventArgs e)
        {
            /// Ajoute la photo importée a la pellicule et laffiche dans la picturebox       
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Picture pic = new Picture(System.Drawing.Image.FromFile(openFileDialog1.FileName));
                show_vignette(pic);
            }
        }

        private void AlbumGrid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Diapo_Click(object sender, EventArgs e)
        {
            Diapo new_Diapo = new Diapo();
            new_Diapo.ShowDialog();
        }

        private void ListaAlbums_Load(object sender, EventArgs e)
        {

        }

    }
}
