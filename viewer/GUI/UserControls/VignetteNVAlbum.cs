using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace viewer.GUI.UserControls
{
    public partial class VignetteNVAlbum : viewer.VignetteNV
    {
        #region Properties
        public Album albumLinked;
        #endregion Properties
        #region Constructeurs
        public VignetteNVAlbum(Album alb)
        {
            InitializeComponent();
            albumLinked = alb;
            this.refreshPreviewPicture();
        } 
        #endregion

        /// <summary>
        /// Met à jour les composants de la vignette avec les données de l'album lié.
        /// </summary>
        public void refreshPreviewPicture()
        {
            if (albumLinked != null)
            {
                this.labelDate.Text = albumLinked.Date;
                this.labelName.Text = albumLinked.Title;
                this.labelSubtitle.Text = albumLinked.SubTitle;
                this.labelNumPhotos.Text = albumLinked.Pictures.Count.ToString() + " Images";

                //Si l'album contient des images, alors:
                if (albumLinked.Pictures.Count > 0)
                {
                    pic = albumLinked.Pictures[0];
                    this.pbPreviewPicture.Image = pic.Image;
                    this.pbPreviewPicture.SizeMode = PictureBoxSizeMode.Zoom;
                    this.pbPreviewPicture.Size = new Size(256, 256);
                }
             }
         }
         #region AttributsModification
        //modification des attributs de lalbum lorsqu'on double clique sur le texte
       protected override void labelName_DoubleClick(object sender, EventArgs e)
        {
            AddAlbumWindow rename = new AddAlbumWindow(albumLinked);
            rename.ShowDialog();
            refreshPreviewPicture();
        }
        //modification des attributs de lalbum lorsqu'on double clique sur limage
        protected override void pbPreviewPicture_DoubleClick(object sender, EventArgs e)
        {
            AddAlbumWindow rename = new AddAlbumWindow(albumLinked);
            rename.ShowDialog();
            refreshPreviewPicture();
        }
        #endregion AttributsModification
    }
}
