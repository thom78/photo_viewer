using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewer
{
    public partial class VignettePhoto : UserControl
    {
        protected Picture Pic;
        protected int intRating;
        public VignettePhoto(Picture picParam)
        {
            InitializeComponent();

            this.Pic = picParam;
            this.pbPhoto.Image = Pic.Image;
            this.pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbPhoto.Size = new Size(256, 256);
            this.toolTip1.SetToolTip(this.pbPhoto, Pic.Comment);
            this.labelTitrePhoto.Text = Pic.Name;
            this.labelDate.Text = Pic.Date;
            this.intRating = Pic.intPicRating;

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
            this.Pic.intPicRating = intRating;
        }

        private void rbNote2_CheckedChanged(object sender, EventArgs e)
        {
            this.intRating = 2;
            this.Pic.intPicRating = intRating;
        }

        private void rbNote3_CheckedChanged(object sender, EventArgs e)
        {
            this.intRating = 3;
            this.Pic.intPicRating = intRating;
        }

        private void rbNote4_CheckedChanged(object sender, EventArgs e)
        {
            this.intRating = 4;
            this.Pic.intPicRating = intRating;
        }

        private void rbNote5_CheckedChanged(object sender, EventArgs e)
        {
            this.intRating = 5;
            this.Pic.intPicRating = intRating;
        }
        #endregion radioButtonsChecked
    }
}
