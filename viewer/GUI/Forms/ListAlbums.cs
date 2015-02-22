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
        private VignetteNVAlbum vignetteAlbumSelected;
        private VignetteNVPhoto vignettePhotoSelected;
        private List<VignetteNVPhoto> listPhotosSelected = new List<VignetteNVPhoto>();
        private List<string> Name_photo_suppr = new List<string>();


        /// <summary>
        /// Fonction qui instancie une nouvelle vignette correspondant à une image (Picture) afin de l'afficher sur l'interface.
        /// </summary>
        /// <param name="pic">Objet Picture correspondant à la vignette.</param>
        private void AddControlVignettePhoto(Picture pic)
        {
            VignetteNV vignetteImage = new VignetteNVPhoto(pic);
            AllPhotosGrid.Controls.Add(vignetteImage);

            vignetteImage.ehClickOnAlbum += new EventHandler(ClickOnVignettePhoto);
        }

        /// <summary>
        /// Fonction qui instancie une nouvelle vignette correspondant à un album afin de l'afficher sur l'interface.
        /// </summary>
        /// <param name="pic">Objet Album correspondant à la vignette.</param>
        private void AddControlVignetteAlbum(Album alb)
        {
            VignetteNV vignetteAlbum = new VignetteNVAlbum(alb);
            //ListAlbums s'abonne à l'évènement de la vignette d'album correspondant à un clic de l'utilisateur.
            //Cet évènement sera traité avec la méthode ClickOnVignetteAlbum
            AlbumGrid.Controls.Add(vignetteAlbum);

            vignetteAlbum.ehClickOnAlbum += new EventHandler(ClickOnVignetteAlbum);

            vignetteAlbumSelected = vignetteAlbum as VignetteNVAlbum;
            refreshViewPicturesList();
        }

        public ListAlbums()
        {
            InitializeComponent();

            //On charge les données utilisateurs si elles existent.
            if (File.Exists("user_data.xml"))
            {
                XML_Serialization.load_user_data();
            }

            //On définit l'album par défaut si il existe
            if (Program.Albums.Count > 0)
            {
                /// Affichage d'images en grid
                AllPhotosGrid.FlowDirection = FlowDirection.LeftToRight;
                AllPhotosGrid.AutoScroll = true;

                foreach (Picture picture in Program.Albums.FirstOrDefault().Pictures)
                {
                    AddControlVignettePhoto(picture);
                }

                /// Affichage des albums
                AlbumGrid.FlowDirection = FlowDirection.LeftToRight;
                AlbumGrid.AutoScroll = true;

                foreach (Album album in Program.Albums)
                {
                    AddControlVignetteAlbum(album);
                }
            }
        }

        private void createAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAlbumWindow dialogNewAlbum = new AddAlbumWindow();
            dialogNewAlbum.ShowDialog();
            if (dialogNewAlbum.DialogResult == DialogResult.OK)
            {
                AddControlVignetteAlbum(dialogNewAlbum.created_album);
                this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
                this.toolStripStatusLabel1.Text = dialogNewAlbum.created_album.Title + " a été créé avec succès.";
            }
        }

        private void importPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /// Ajoute la photo importée à l'album sélectionné et l'affiche dans la picturebox       
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String fileName in openPictureDialog.FileNames)
                {
                    importPictures(fileName);
                }
                //Emplacement temporaire pour l'appel à la méthode de sérialisation. //A changer.//
                XML_Serialization.save_user_data();
            }
        }

        private void diaporamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diapo new_Diapo = new Diapo(this.vignetteAlbumSelected.albumLinked);
            new_Diapo.ShowDialog();
        }
        private void ClickOnVignetteAlbum(object sender, EventArgs e)
        {
            //La vignette d'albums dont on souhaite afficher le contenu est l'émetteur de l'évènement. (C'est celle sur laquelle l'utilisateur a cliqué)
            vignetteAlbumSelected = sender as VignetteNVAlbum;

            listPhotosSelected.Clear();
            refreshViewPicturesList();

        }

        /// <summary>
        ///  Fonction appelée pour ajouter des images dans un album photo à partir des chemins de fichiers (et qui les sérialise).
        /// </summary>
        /// <param name="strFileName">Chemin du fichier correspondant à l'image.</param>
        private void importPictures(String strFileName)
        {
            String strName = Path.GetFileNameWithoutExtension(strFileName);
            String strDate = File.GetCreationTimeUtc(strFileName).ToShortDateString();

            if ((vignetteAlbumSelected != null))
            {
                if (!(vignetteAlbumSelected.albumLinked.Pictures.Exists(a => a.picturePath == strFileName)))
                {
                    Picture pic = new Picture(System.Drawing.Image.FromFile(strFileName), strFileName, strName, 0, "", strDate, vignetteAlbumSelected.albumLinked);
                    AddControlVignettePhoto(pic);
                    vignetteAlbumSelected.refreshPreviewPicture();
                    this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
                    this.toolStripStatusLabel1.Text = pic.Name + " a été importée avec succès.";
                }
            }
            else if ((vignetteAlbumSelected == null))
            {
                this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
                this.toolStripStatusLabel1.Text = "Aucun album sélectionné!";
            }
        }

        //Les fichiers déplacés sont copiés en mémoire lorsque la souris arrive sur le contrôle avec les fichiers déplacés.
        private void AllPhotosGrid_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        //On récupère le chemin des fichiers déplacés sous forme de String lorsque le bouton de la souris est relâché ("drop").
        private void AllPhotosGrid_DragDrop(object sender, DragEventArgs e)
        {
            List<String> listAllowedFileExt = new List<String>() { ".jpeg", ".jpg", ".png", ".bmp", ".gif" };

            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];

            //On teste si les fichiers déplacés correspondent à des images.
            foreach (string strFileName in files)
            {
                if (listAllowedFileExt.Contains(Path.GetExtension(strFileName)))
                {
                    //On les ajoute à l'album sélectionné si il existe.
                    importPictures(strFileName);
                }
            }
            //On sauvegarde les données.
            XML_Serialization.save_user_data();
        }
        private void refreshViewPicturesList()
        {
            //On rafraichit la liste de photos du contrôle AllPhotosGrid à partir des photos contenu dans l'album de la vignette.
            AllPhotosGrid.Controls.Clear();
            foreach (Picture pic in vignetteAlbumSelected.albumLinked.Pictures)
            {
                AddControlVignettePhoto(pic);
            }
        }

        #region TriePhotos
        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vignetteAlbumSelected.albumLinked.Pictures = vignetteAlbumSelected.albumLinked.Pictures.OrderBy(a => a.Date).ToList();
            refreshViewPicturesList();
            XML_Serialization.save_user_data();
        }

        private void nomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vignetteAlbumSelected.albumLinked.Pictures = vignetteAlbumSelected.albumLinked.Pictures.OrderBy(a => a.Name).ToList();
            refreshViewPicturesList();
            XML_Serialization.save_user_data();
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vignetteAlbumSelected.albumLinked.Pictures = vignetteAlbumSelected.albumLinked.Pictures.OrderBy(a => a.intPicRating).ToList();
            refreshViewPicturesList();
            XML_Serialization.save_user_data();
        }
        #endregion TriePhotos

        private void ClickOnVignettePhoto(object sender, EventArgs e)
        {
            vignettePhotoSelected = sender as VignetteNVPhoto;
            if (listPhotosSelected.Contains(vignettePhotoSelected))
            {
                listPhotosSelected.Remove(vignettePhotoSelected);
                vignettePhotoSelected.BackColor = System.Drawing.Color.White;
            }
            else if (!listPhotosSelected.Contains(vignettePhotoSelected))
            {
                listPhotosSelected.Add(vignettePhotoSelected);
                vignettePhotoSelected.BackColor = System.Drawing.Color.DodgerBlue;
            }
            //Name_photo_suppr.Add(vignettePhotoSelected.pic.Name);
        }


        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Picture> listTempRemPic = new List<Picture>();

            if (listPhotosSelected.Count == 0)
            {
                Program.Albums.Remove(vignetteAlbumSelected.albumLinked);
                AlbumGrid.Controls.Clear();
                foreach(Album alb in Program.Albums)
                {
                    AddControlVignetteAlbum(alb);
                }
            }
            else if (listPhotosSelected.Count > 0)
            {
                foreach (VignetteNVPhoto vignettePic in listPhotosSelected)
                {
                    listTempRemPic.Add(vignettePic.pic);
                }

                foreach (Picture pic in listTempRemPic)
                {
                    //Actuellement le code permet de sélectionner des photos provenant d'albums différents, il faut donc tester si les photos sont bien dans l'album sélectionné avant de les supprimer.
                    //Ce test if n'est plus nécessaire dès qu'on appelle la fonction listPhotosSelected.Clear() à chaque fois qu'on clique sur une vignette d'album.
                    if (vignetteAlbumSelected.albumLinked.Pictures.Exists(a => a == pic))
                    {
                        vignetteAlbumSelected.albumLinked.Pictures.Remove(pic);
                    }
                }
                //On vide la liste des vignettes sélectionnées en mémoire.
                listPhotosSelected.Clear();

                vignetteAlbumSelected.refreshPreviewPicture();
                refreshViewPicturesList();
                XML_Serialization.save_user_data();
            }
        }

    }

}
