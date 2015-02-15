﻿using System;
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
/// NB: Le premier album en haut a gauche sera toujours l'album "Pellicule" dans lequel on trouve l'integralité des photos 
/// --->>> a chaque fois quon importe des photos, ne pas oublier de les ajouter à lalbum "pellicule"!
/// a faire: creation album, ajout de photos a album
/// CREER UNE FONCTIN : AJOUT DE PHOTO DANS UNE GRID AU LIEU DE COPIER COLLER LE TEXTE TOUT LE TOUT LE TEMPS
/// supprimer albums, photos
/// *********************************************************************************************************************************************************

namespace viewer
{
    public partial class ListAlbums : Form
    {
        private void show_vignette(Picture pic)
        {
            Vignette vignetteImage = new Vignette_image(pic);
            AllPhotosGrid.Controls.Add(vignetteImage);
        }

        private void show_vignette(Album alb)
        {
            Vignette_alb vignetteAlbum = new Vignette_alb(alb);
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
            /// Ajoute la photo importée a la pellicule et laffiche dans la picturebox       
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                foreach(String fileName in openPictureDialog.FileNames)
                {
                String name = Path.GetFileNameWithoutExtension(fileName);
                String date = File.GetCreationTimeUtc(fileName).ToShortDateString();

                Picture pic = new Picture(System.Drawing.Image.FromFile(fileName), fileName, name, 0, "", date);
                show_vignette(pic);
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
            Vignette_alb vignette_album = sender as Vignette_alb;
            AllPhotosGrid.Controls.Clear();
                foreach(Picture pic in vignette_album.Alb.Pictures)
                {
                    show_vignette(pic);
                }
        }
    }
}
