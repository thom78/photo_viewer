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
        public VignetteNVAlbum(Album alb)
        {
            InitializeComponent();
            albumLinked = alb;
            this.refreshPreviewPicture();
        }

        public void refreshPreviewPicture()
        {
            if ((albumLinked != null) && (albumLinked.Pictures.Count > 0))
            {
                this.labelDate.Text = albumLinked.Date;
                this.labelName.Text = albumLinked.Title;
                this.labelSubtitle.Text = albumLinked.SubTitle;
                this.labelNumPhotos.Text = albumLinked.Pictures.Count.ToString() + " Images";
                pic = albumLinked.Pictures[0];
                this.pbPreviewPicture.Image = pic.Image;
                this.pbPreviewPicture.SizeMode = PictureBoxSizeMode.Zoom;
                this.pbPreviewPicture.Size = new Size(256, 256);
            }
        }
    }
}
