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
    abstract public partial class Vignette : UserControl
    {
        //definition de limage de la vignette
        protected Picture Pic;
        public Vignette()
        {
            InitializeComponent();
        }

        private void PhotoVignette_MouseLeave(object sender, EventArgs e)
        {
            if (!this.Bounds.Contains(PointToClient(MousePosition)))
            {
                InfoBox.Visible = false;
            }
        }

        protected abstract void PhotoVignette_Click(object sender, EventArgs e);
        protected abstract void PhotoVignette_MouseEnter(object sender, EventArgs e);
    }
}
