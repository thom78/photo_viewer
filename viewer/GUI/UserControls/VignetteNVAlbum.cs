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
        public Album linkedAlb;
        #endregion Properties
        public VignetteNVAlbum(Album alb)
        {
            InitializeComponent();
            linkedAlb = alb;
            this.refreshPreviewPicture();
        }

        public void refreshPreviewPicture()
        {
            if ((linkedAlb != null) && (linkedAlb.Pictures.Count > 0))
            {
                this.labelDate.Text = linkedAlb.Date;
                this.labelName.Text = linkedAlb.Title;
                this.labelSubtitle.Text = linkedAlb.SubTitle;
                this.labelNumPhotos.Text = linkedAlb.Pictures.Count.ToString() + " Images";
                pic = linkedAlb.Pictures[0];
                this.pbPreviewPicture.Image = pic.Image;
                this.pbPreviewPicture.SizeMode = PictureBoxSizeMode.Zoom;
                this.pbPreviewPicture.Size = new Size(256, 256);
            }
        }
    }
}
