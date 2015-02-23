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
        #region Attributs
        private VignetteNVAlbum vignetteAlbumSelected = null;
        private VignetteNVPhoto vignettePhotoSelected = null;
        private List<VignetteNVPhoto> listPhotosSelected = new List<VignetteNVPhoto>();
        private List<VignetteNVAlbum> listAlbumsSelected = new List<VignetteNVAlbum>();
        #endregion Attributs

        #region ConstructeurEtInit
        public ListAlbums()
        {
            List<VignetteNVAlbum> listVignetteTemp = new List<VignetteNVAlbum>();
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
                    listVignetteTemp.Add(AddControlVignetteAlbum(album));
                }
                if (listVignetteTemp.Count > 0)
                {
                    vignetteAlbumSelected = listVignetteTemp.FirstOrDefault();
                    listAlbumsSelected.Add(vignetteAlbumSelected);
                    vignetteAlbumSelected.BackColor = System.Drawing.SystemColors.Highlight;
                    refreshViewPicturesList();
                }
            }
        }
        #endregion ConstructeurEtInit

        #region SuppressionAlbumsOuPhotos
        private void deletePhotosOrAlbums()
        {
            List<Picture> listTempRemPic = new List<Picture>();
            List<Album> listTempRemAlb = new List<Album>();
            List<VignetteNVAlbum> listVignetteTemp = new List<VignetteNVAlbum>();
            String strName = "";

            if ((listAlbumsSelected.Count > 0) && (listPhotosSelected.Count == 0))
            {
                foreach (VignetteNVAlbum vignetteAlb in listAlbumsSelected)
                {
                    listTempRemAlb.Add(vignetteAlb.albumLinked);
                    vignetteAlb.albumLinked.Pictures.Clear();
                    strName = strName + vignetteAlb.albumLinked.Title + ", ";
                }
                strName = strName.TrimEnd((','), (' '));
                foreach (Album alb in listTempRemAlb)
                {
                    Program.Albums.Remove(alb);
                }
                listAlbumsSelected.Clear();
                vignetteAlbumSelected = null;
                //On rafraichit la vue des albums.
                AlbumGrid.Controls.Clear();
                //Si il reste des albums...
                if (Program.Albums.Count > 0)
                {
                    //Alors on remplit l'affichage avec des vignettes d'album.
                    foreach (Album alb in Program.Albums)
                    {
                        listVignetteTemp.Add(AddControlVignetteAlbum(alb));
                    }
                    //Et la vignette d'album sélectionnée devient la dernière vignette ajoutée.
                    vignetteAlbumSelected = listVignetteTemp.LastOrDefault();
                    listAlbumsSelected.Add(vignetteAlbumSelected);
                    vignetteAlbumSelected.BackColor = System.Drawing.SystemColors.Highlight;
                }
                refreshViewPicturesList();
                //On sauvegarde les modifications.
                XML_Serialization.save_user_data();

                this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
                this.toolStripStatusLabel1.Text = "Album(s) " + strName + " supprimé(s) avec succès.";
            }
            else if ((listAlbumsSelected.Count > 0) && (listPhotosSelected.Count > 0))
            {
                foreach (VignetteNVPhoto vignettePic in listPhotosSelected)
                {
                    listTempRemPic.Add(vignettePic.pic);
                    strName = strName + vignettePic.pic.Name + ", ";
                }
                //On enlève la dernière virgule
                strName = strName.TrimEnd((','), (' '));

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

                this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
                this.toolStripStatusLabel1.Text = "Image(s) " + strName + " supprimée(s) avec succès.";

                vignetteAlbumSelected.refreshPreviewPicture();
                refreshViewPicturesList();
                XML_Serialization.save_user_data();
            }
        }
        #endregion SuppressionAlbumsOuPhotos

        #region ImportPhotos
        /// <summary>
        ///  Fonction appelée pour ajouter des images dans un album photo à partir des chemins de fichiers (et qui les sérialise).
        /// </summary>
        /// <param name="strFileName">Chemin du fichier correspondant à l'image.</param>
        private void importPictures(String[] astrFileNames)
        {
            Boolean boolAtLeastOnePicAdded = false;
            List<String> listAllowedFileExt = new List<String>() { ".jpeg", ".jpg", ".png", ".bmp", ".gif" };
            String strPicName = "";

            if ((vignetteAlbumSelected != null))
            {

                foreach (String strFileName in astrFileNames)
                {

                    if (listAllowedFileExt.Contains(Path.GetExtension(strFileName)))
                    {
                        if (!(vignetteAlbumSelected.albumLinked.Pictures.Exists(a => a.picturePath == strFileName)))
                        {
                            String strName = Path.GetFileNameWithoutExtension(strFileName);
                            String strDate = File.GetCreationTimeUtc(strFileName).ToShortDateString();

                            strPicName = strPicName + strName + ", ";

                            Picture pic = new Picture(System.Drawing.Image.FromFile(strFileName), strFileName, strName, 0, "", strDate, vignetteAlbumSelected.albumLinked);
                            AddControlVignettePhoto(pic);
                            boolAtLeastOnePicAdded = true;
                        }
                    }
                }
                vignetteAlbumSelected.refreshPreviewPicture();

                if (boolAtLeastOnePicAdded)
                {
                    //On enlève la dernière virgule.
                    strPicName = strPicName.TrimEnd((','), (' '));

                    this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.toolStripStatusLabel1.Text = "Image(s) " + strPicName + " importée(s) avec succès.";

                    //On sauvegarde les modifications.
                    XML_Serialization.save_user_data();
                }
                else
                {
                    this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.toolStripStatusLabel1.Text = "Les images importées existent déjà dans l'album.";
                }
            }
            else if ((vignetteAlbumSelected == null))
            {
                this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
                this.toolStripStatusLabel1.Text = "Aucun album sélectionné!";
            }
        }
        #endregion ImportPhotos

        #region Interface

        #region TriePhotos
        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vignetteAlbumSelected != null)
            {
                vignetteAlbumSelected.albumLinked.Pictures = vignetteAlbumSelected.albumLinked.Pictures.OrderBy(a => a.Date).ToList();
                refreshViewPicturesList();
                XML_Serialization.save_user_data();
            }
        }

        private void nomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vignetteAlbumSelected != null)
            {
                vignetteAlbumSelected.albumLinked.Pictures = vignetteAlbumSelected.albumLinked.Pictures.OrderBy(a => a.Name).ToList();
                refreshViewPicturesList();
                XML_Serialization.save_user_data();
            }
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vignetteAlbumSelected != null)
            {
                vignetteAlbumSelected.albumLinked.Pictures = vignetteAlbumSelected.albumLinked.Pictures.OrderBy(a => a.intPicRating).ToList();
                refreshViewPicturesList();
                XML_Serialization.save_user_data();
            }
        }
        #endregion TriePhotos

        #region DragAndDropPhotos
        //Les fichiers déplacés sont copiés en mémoire lorsque la souris arrive sur le contrôle avec les fichiers déplacés.
        private void AllPhotosGrid_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        //On récupère le chemin des fichiers déplacés sous forme de String lorsque le bouton de la souris est relâché ("drop").
        private void AllPhotosGrid_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];

            //On les ajoute à l'album sélectionné si il existe.
            importPictures(files);
        }
        #endregion DragAndDropPhotos

        #region Evènements
        private void ClickOnVignettePhoto(object sender, EventArgs e)
        {
            vignettePhotoSelected = sender as VignetteNVPhoto;
            if (listPhotosSelected.Contains(vignettePhotoSelected))
            {
                listPhotosSelected.Remove(vignettePhotoSelected);
                vignettePhotoSelected.BackColor = System.Drawing.SystemColors.Control;
                if (listPhotosSelected.Count > 0)
                {
                    vignettePhotoSelected = listPhotosSelected.LastOrDefault();
                }
                else if (listPhotosSelected.Count == 0)
                {
                    vignettePhotoSelected = null;
                }
            }
            else if (!listPhotosSelected.Contains(vignettePhotoSelected))
            {
                listPhotosSelected.Add(vignettePhotoSelected);
                vignettePhotoSelected.BackColor = System.Drawing.SystemColors.Highlight;
            }
        }
        private void ClickOnVignetteAlbum(object sender, EventArgs e)
        {
            vignetteAlbumSelected = sender as VignetteNVAlbum;

            if (listAlbumsSelected.Contains(vignetteAlbumSelected))
            {
                //Si on a un seul album sélectionné, on ne peut pas le déselectionner
                if (listAlbumsSelected.Count > 1)
                {
                    listAlbumsSelected.Remove(vignetteAlbumSelected);
                    vignetteAlbumSelected.BackColor = System.Drawing.SystemColors.Control;
                                        
                    vignetteAlbumSelected = listAlbumsSelected.LastOrDefault();
                }                
            }
            else if (!listAlbumsSelected.Contains(vignetteAlbumSelected))
            {
                listAlbumsSelected.Add(vignetteAlbumSelected);
                vignetteAlbumSelected.BackColor = System.Drawing.SystemColors.Highlight;
                refreshViewPicturesList();
            }
            listPhotosSelected.Clear();
        }
        #endregion Evènements

        #region Boutons
        private void createAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAlbumWindow dialogNewAlbum = new AddAlbumWindow();
            dialogNewAlbum.ShowDialog();
            if (dialogNewAlbum.DialogResult == DialogResult.OK)
            {
                vignetteAlbumSelected=AddControlVignetteAlbum(dialogNewAlbum.created_album);
                listAlbumsSelected.Add(vignetteAlbumSelected);
                vignetteAlbumSelected.BackColor = System.Drawing.SystemColors.Highlight;
                refreshViewPicturesList();

                this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
                this.toolStripStatusLabel1.Text = dialogNewAlbum.created_album.Title + " a été créé avec succès.";                
                XML_Serialization.save_user_data();
            }            
        }

        private void importPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /// Ajoute la photo importée à l'album sélectionné et l'affiche dans la picturebox       
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                importPictures(openPictureDialog.FileNames);
            }
        }

        private void diaporamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vignetteAlbumSelected != null)
            {
                Diapo new_Diapo = new Diapo(this.vignetteAlbumSelected.albumLinked);
                new_Diapo.ShowDialog();
            }
            else
            {
                this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
                this.toolStripStatusLabel1.Text = "Aucun album sélectionné!";
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletePhotosOrAlbums();
        }
        #endregion Boutons

        #region AffichageDesVignettes
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
        private VignetteNVAlbum AddControlVignetteAlbum(Album alb)
        {
            VignetteNVAlbum vignetteAlbum = new VignetteNVAlbum(alb);
            //ListAlbums s'abonne à l'évènement de la vignette d'album correspondant à un clic de l'utilisateur.
            //Cet évènement sera traité avec la méthode ClickOnVignetteAlbum
            AlbumGrid.Controls.Add(vignetteAlbum);

            vignetteAlbum.ehClickOnAlbum += new EventHandler(ClickOnVignetteAlbum);

            return vignetteAlbum;
        }
        private void refreshViewPicturesList()
        {
            //On rafraichit la liste de photos du contrôle AllPhotosGrid à partir des photos contenu dans l'album de la vignette.
            AllPhotosGrid.Controls.Clear();
            if (vignetteAlbumSelected != null)
            {
                foreach (Picture pic in vignetteAlbumSelected.albumLinked.Pictures)
                {
                    AddControlVignettePhoto(pic);
                }
            }
        }
        #endregion AffichageDesVignettes

        #endregion Interface

    }
}
