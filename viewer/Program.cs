using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewer
{
    static class Program
    {
        //creation d'une liste chainee d'Albums
        public static List<Album> Albums = new List<Album>();

        //creation de l'album pellicule qui contient toutes les photos
        public static Album Pellicule = new Album("Pellicule","",DateTime.Now.ToShortDateString());

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListAlbums());
        }
    }
}
