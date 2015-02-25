using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewer
{
    public partial class DeleteWindow : Form
    {
        #region Attributs
        public bool valide = false;
        #endregion Attributs

        #region ConstructeursEtInit
        public DeleteWindow(int type)
        {
            InitializeComponent();
            if (type == 0 )
            {
                textlabel.Text = "Êtes-vous sûr de vouloir supprimer ces éléments?";
            }
            if ( type == 1)
            {

            }
        }
        #endregion ConstructeursEtInit

        #region interface
        private void but_ok_Click(object sender, EventArgs e)
        {
            valide = true;
            this.Close();
        }

        private void but_ko_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion interface
    }
}
