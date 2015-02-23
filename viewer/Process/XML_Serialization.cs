using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace viewer
{
    class XML_Serialization
    {
        /// <summary>
        /// Sauvegarde les Albums et leurs Pictures vers le fichier user_data.xml dans le répertoire courant.
        /// </summary>
        public static void save_user_data()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Album>));
            using (StreamWriter wr = new StreamWriter("user_data.xml"))
            {
                xs.Serialize(wr, Program.Albums);
            }
        }

        /// <summary>
        /// Charge les Albums et leurs Pictures à partir du fichier user_data.xml dans le répertoire courant.
        /// </summary>
        public static void load_user_data()
        {
            Boolean boolAlbumCorrupted;
            Boolean boolShowDialog = false;
            String strDialogText = "";
            List<Picture> tempRemPicList = new List<Picture>();

            XmlSerializer xs = new XmlSerializer(typeof(List<Album>));
            using (StreamReader rd = new StreamReader("user_data.xml"))
            {
                Program.Albums = xs.Deserialize(rd) as List<Album>;
            }

            //Les bitmap ne pouvant pas être sérialisés, on réattribue un bitmap à chaque objet Picture à partir du son chemin (String) qui a été sérialisé.
            foreach (Album alb in Program.Albums)
            {
                boolAlbumCorrupted = false;
                foreach (Picture pic in alb.Pictures)
                {
                    //On teste si l'image existe toujours (si elle n'a pas été déplacée ou supprimée en dehors du programme. AUquel cas le chemin ne correspond plus à rien)
                    if (File.Exists(pic.picturePath))
                    {
                        pic.Image = System.Drawing.Image.FromFile(pic.picturePath);
                    }
                    //Si le chemin ne correspond plus à rien, alors on supprime l'image de l'album. //Afficher un message à l'utilisateur avec le chemin des images non trouvées: à faire. //
                    else if (!File.Exists(pic.picturePath))
                    {
                        //On stocke l'image à supprimer dans une liste temporaire
                        tempRemPicList.Add(pic);
                        //L'album est déclaré corrompu
                        boolAlbumCorrupted = true;
                    }
                }
                //Si l'album est corrompu
                if (boolAlbumCorrupted)
                {
                    //On affichera la fenêtre d'erreur pour avertir l'utilisateur.
                    boolShowDialog = true;
                    strDialogText = strDialogText + "Dans l'album " + alb.Title + ":\n";
                    //On supprime les images de l'album introuvables dont les références sont stockées dans la liste temporaire.
                    foreach (Picture remPic in tempRemPicList)
                    {
                        alb.Pictures.Remove(remPic);
                        //On enregistre les données de l'image introuvable dans une chaîne de caractère pour pouvoir les afficher.
                        strDialogText = strDialogText + "L'image " + remPic.Name + " à l'emplacement:\n\t" + remPic.picturePath + "\n";
                        
                    }
                    //On vide la liste temporaire
                    tempRemPicList.Clear();
                }
            }
            if (boolShowDialog)
            {
                System.Windows.Forms.MessageBox.Show("Les images suivantes n'ont pas été trouvées et ont été supprimées:\n" + strDialogText, "Images introuvables");
                save_user_data();
            }
        }
    }
}
