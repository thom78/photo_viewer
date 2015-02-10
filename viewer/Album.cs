using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace viewer
{
    public class Album : IComparable<Album>
    {
        #region Properties

        [XmlElement(ElementName = "Titre")]
        public String Title { get; set; }

        [XmlElement(ElementName = "Sous-Titre")]
        public String SubTitle { get; set; }

        [XmlAttribute(AttributeName = "Date")]
        public String Date { get; set; }

        //liste des photos contenues dans l'album
        //[XmlIgnore]
        public List<Picture> Pictures = new List<Picture>();

        #endregion Properties

        #region Constructor(s)
        public Album() { }
        public Album(String title, String subtitle, String date)
        {
            this.Title = title;
            this.SubTitle = subtitle;
            this.Date = date;
            //on ajoute le nouvel album créé à la liste
            Program.Albums.Add(this);
        }

        #endregion Constructor(s)

        #region Method_Sort

        int IComparable<Album>.CompareTo(Album other)
        {
            return this.Title.CompareTo(other.Title);
        }

        #endregion Method_Sort
    }
}
