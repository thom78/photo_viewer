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

///**********************************************************************************************************************************************************

/// *********************************************************************************************************************************************************

namespace viewer
{
    public partial class ListAlbums : Form
    {
        private Vignette_alb albumSelected = new Vignette_alb(null);

        private void show_vignette(Picture pic)
        {
            Vignette vignetteImage = new Vignette_image(pic);
            AllPhotosGrid.Controls.Add(vignetteImage);
        }

        private void show_vignette(Album alb)
        {
            Vignette_alb vignetteAlbum = new Vignette_alb(alb);
            //ListAlbums s'abonne à l'évènement de la vignette d'album correspondant à un clic de l'utilisateur.
            //Cet évènement sera traité avec la méthode vignette_AlbumWasClicked
            vignetteAlbum.clickOnAlbum += new EventHandler(vignette_AlbumWasClicked);
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
            show_vignette(new_album.created_album);
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

                    if((albumSelected.Alb!=null)&&(!(albumSelected.Alb.Pictures.Exists(a=>a.picturePath==fileName))))
                    {
                        Picture pic = new Picture(System.Drawing.Image.FromFile(fileName), fileName, name, 0, "", date, albumSelected.Alb);
                        show_vignette(pic);
                    }
                }
                //Emplacement temporaire pour l'appel à la méthode de sérialisation. //A changer.//
                XML_Serialization.save_user_data();
            }
        }

        private void diaporamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diapo new_Diapo = new Diapo();
            new_Diapo.ShowDialog();
        }
        private void vignette_AlbumWasClicked(object sender, EventArgs e)
        {
            //La vignette d'albums dont on souhaite afficher le contenu est l'émetteur de l'évènement. (C'est celle sur laquelle l'utilisateur a cliqué)
            albumSelected = sender as Vignette_alb;

            //On rafraichit la liste de photos du contrôle AllPhotosGrid à partir des photos contenu dans l'album de la vignette.
            AllPhotosGrid.Controls.Clear();
            foreach (Picture pic in albumSelected.Alb.Pictures)
            {
                show_vignette(pic);
            }
        }
    }
}
