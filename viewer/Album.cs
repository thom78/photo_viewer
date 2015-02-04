using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace viewer
{
    class Album : IComparable<Album>
    {
        #region Properties

        [XmlElement(ElementName = "Titre")]
        public String Title { get; set; }

        [XmlElement(ElementName = "Sous-Titre")]
        public String SubTitle { get; set; }

        [XmlAttribute(AttributeName = "Date")]
        public String Date { get; set; }

        //liste des photos contenues dans l'album
        public List<Picture> Pictures = new List<Picture>();

        #endregion Properties

        #region Constructor(s)

        public Album()
        {
            //on ajoute le nouvel album crée a la liste chainée
            Albums.Add(this);
        }

        public Album(String title, String subtitle, String date)
        {
            this.Title = title;
            this.SubTitle = subtitle;
            this.Date = date;
            //on ajoute le nouvel album crée a la liste chainée
            Albums.Add(this);
        }

        public Album(String title)
        {
            this.Title = title;
            //on ajoute le nouvel album crée a la liste chainée
            Albums.Add(this);
        }

        #endregion Constructor(s)

        #region Method_Sort

        int IComparable<Album>.CompareTo(Album other)
        {
            return this.Title.CompareTo(other.Title);
        }

        #endregion Method_Sort

        //creation d'une liste chainee d'Albums
        public static List<Album> Albums = new List<Album>();

        //creation de l'album pellicule qui contient toutes les photos
        public static Album Pellicule = new Album("Pellicule");
    }
}
