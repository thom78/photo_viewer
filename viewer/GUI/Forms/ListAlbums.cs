using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using viewer.GUI.UserControls;

///**********************************************************************************************************************************************************
/// NB: Le premier album en haut a gauche sera toujours l'album "Pellicule" dans lequel on trouve l'integralité des photos 
/// --->>> a chaque fois quon importe des photos, ne pas oublier de les ajouter à lalbum "pellicule"!
/// a faire: creation album, ajout de photos a album
/// CREER UNE FONCTION : AJOUT DE PHOTO DANS UNE GRID AU LIEU DE COPIER COLLER LE TEXTE TOUT LE TOUT LE TEMPS
/// supprimer albums, photos
/// *********************************************************************************************************************************************************

namespace viewer
{
    public partial class ListAlbums : Form
    {
        private VignetteNVAlbum vignetteAlbumSelected = new VignetteNVAlbum(null);

        private void show_vignette(Picture pic)
        {
            VignetteNV vignetteImage = new VignetteNVPhoto(pic);
            AllPhotosGrid.Controls.Add(vignetteImage);
        }

        private void show_vignette(Album alb)
        {
            VignetteNV vignetteAlbum = new VignetteNVAlbum(alb);
            //ListAlbums s'abonne à l'évènement de la vignette d'album correspondant à un clic de l'utilisateur.
            //Cet évènement sera traité avec la méthode ClickOnVignetteAlbum
            vignetteAlbum.ehClickOnAlbum += new EventHandler(ClickOnVignetteAlbum);
            AlbumGrid.Controls.Add(vignetteAlbum);
        }

        public ListAlbums()
        {
            InitializeComponent();

            //On charge les données utilisateurs si elles existent.
            if (File.Exists("user_data.xml"))
            {
                XML_Serialization.load_user_data();
            }

            /// Affichage d'images en grid
            AllPhotosGrid.FlowDirection = FlowDirection.LeftToRight;
            AllPhotosGrid.AutoScroll = true;

            foreach (Picture picture in Program.Albums.FirstOrDefault().Pictures)
            {
                show_vignette(picture);
            }


            /// Affichage des albums
            AlbumGrid.FlowDirection = FlowDirection.LeftToRight;
            AlbumGrid.AutoScroll = true;

            foreach (Album album in Program.Albums)
            {
                show_vignette(album);
            }
        }

        private void créerAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAlbumWindow new_album = new AddAlbumWindow();
            new_album.ShowDialog();
            if (new_album.DialogResult == DialogResult.OK)
            {
                show_vignette(new_album.created_album);
            }
        }

        private void importerPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /// Ajoute la photo importée àl'album sélectionné et l'affiche dans la picturebox       
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String fileName in openPictureDialog.FileNames)
                {
                    String name = Path.GetFileNameWithoutExtension(fileName);
                    String date = File.GetCreationTimeUtc(fileName).ToShortDateString();

                    if ((vignetteAlbumSelected.linkedAlb != null) && (!(vignetteAlbumSelected.linkedAlb.Pictures.Exists(a => a.picturePath == fileName))))
                    {
                        Picture pic = new Picture(System.Drawing.Image.FromFile(fileName), fileName, name, 0, "", date, vignetteAlbumSelected.linkedAlb);
                        show_vignette(pic);
                        vignetteAlbumSelected.refreshPreviewPicture();
                    }
                }
                //Emplacement temporaire pour l'appel à la méthode de sérialisation. //A changer.//
                XML_Serialization.save_user_data();
            }
        }

        private void diaporamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diapo new_Diapo = new Diapo(this.vignetteAlbumSelected.linkedAlb);
            new_Diapo.ShowDialog();
        }
        private void ClickOnVignetteAlbum(object sender, EventArgs e)
        {
            //La vignette d'albums dont on souhaite afficher le contenu est l'émetteur de l'évènement. (C'est celle sur laquelle l'utilisateur a cliqué)
            vignetteAlbumSelected = sender as VignetteNVAlbum;

            //On rafraichit la liste de photos du contrôle AllPhotosGrid à partir des photos contenu dans l'album de la vignette.
            AllPhotosGrid.Controls.Clear();
            foreach (Picture pic in vignetteAlbumSelected.linkedAlb.Pictures)
            {
                show_vignette(pic);
            }
        }
    }
}
