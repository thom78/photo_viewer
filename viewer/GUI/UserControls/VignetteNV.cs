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
    public partial class VignetteNV : UserControl
    {
        public Picture pic;
        public event EventHandler ehClickOnAlbum;
        public event MouseEventHandler ehMouseDown;
        public event DragEventHandler ehDragOver;
        public VignetteNV()
        {
            InitializeComponent();
        }

        private void pbPreviewPicture_Click(object sender, EventArgs e)
        {
            //L'évènement est créé et envoyé aux objets abonnés
            EventHandler eh = ehClickOnAlbum;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private void VignetteNV_MouseDown(object sender, MouseEventArgs e)
        {
            //L'évènement est créé et envoyé aux objets abonnés
            MouseEventHandler eh = ehMouseDown;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        private void VignetteNV_DragOver(object sender, DragEventArgs e)
        {
            //L'évènement est créé et envoyé aux objets abonnés
            DragEventHandler eh = ehDragOver;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        protected virtual void pbPreviewPicture_DoubleClick(object sender, EventArgs e)
        {

        }

        protected virtual void labelName_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
