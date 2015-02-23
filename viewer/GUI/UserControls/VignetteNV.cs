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
    }
}
