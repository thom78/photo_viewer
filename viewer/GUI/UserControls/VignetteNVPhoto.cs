using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace viewer.GUI.UserControls
{
    public partial class VignetteNVPhoto : viewer.VignetteNV
    {
        protected int intRating=0;
        public VignetteNVPhoto(Picture picParam)
        {
            InitializeComponent();

            this.pic = picParam;
            this.pbPreviewPicture.Image = pic.Image;
            this.pbPreviewPicture.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbPreviewPicture.Size = new Size(256, 256);
            this.toolTipPicComment.SetToolTip(this.pbPreviewPicture, pic.Comment);
            this.labelName.Text = pic.Name;
            this.labelDate.Text = pic.Date;
            this.intRating = pic.intPicRating;

            //On affiche la note de la photo avec les radioButtons.
            switch (intRating)
            {
                case 0:
                    this.rbNote1.Checked = false;
                    this.rbNote2.Checked = false;
                    this.rbNote3.Checked = false;
                    this.rbNote4.Checked = false;
                    this.rbNote5.Checked = false;
                    break;
                case 1:
                    this.rbNote1.Checked = true;
                    break;
                case 2:
                    this.rbNote2.Checked = true;
                    break;
                case 3:
                    this.rbNote3.Checked = true;
                    break;
                case 4:
                    this.rbNote4.Checked = true;
                    break;
                case 5:
                    this.rbNote5.Checked = true;
                    break;
            }
        }

        #region radioButtonsChecked
        private void rbNote1_CheckedChanged(object sender, EventArgs e)
        {
            this.intRating = 1;
            this.pic.intPicRating = intRating;
        }

        private void rbNote2_CheckedChanged(object sender, EventArgs e)
        {
            this.intRating = 2;
            this.pic.intPicRating = intRating;
        }

        private void rbNote3_CheckedChanged(object sender, EventArgs e)
        {
            this.intRating = 3;
            this.pic.intPicRating = intRating;
        }

        private void rbNote4_CheckedChanged(object sender, EventArgs e)
        {
            this.intRating = 4;
            this.pic.intPicRating = intRating;
        }

        private void rbNote5_CheckedChanged(object sender, EventArgs e)
        {
            this.intRating = 5;
            this.pic.intPicRating = intRating;
        }
        #endregion radioButtonsChecked
    }
}
