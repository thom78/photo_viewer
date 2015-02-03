using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace viewer
{
    class Picture : IComparable<Picture>
    {
        #region Properties

        [XmlElement(ElementName = "Nom")]
        public String Name { get; set; }

        [XmlElement(ElementName = "Rating")]
        public Int32 Rate { get; set; }

        [XmlElement(ElementName = "Commentaire")]
        public String Comment { get; set; }

        [XmlElement(ElementName = "Date")]
        public String Date { get; set; }

        #endregion Properties

        #region Constructor(s)

        public Picture()
        {
        }

        public Picture(String Name)
        {
            this.Name = Name;
        }

        public Picture(String Name, Int32 rate, String comment, String date)
        {
            this.Name = Name;
            this.Rate = rate;
            this.Comment = comment;
            this.Date = date;
        }

        #endregion Constructor(s)

        #region Method_Sort

        int IComparable<Picture>.CompareTo(Picture other)
        {
            return this.Name.CompareTo(other.Name);
        }

        #endregion Method_Sort

        //creation d'une liste chainee d'images
        public static List<Picture> Pictures = new List<Picture>();
    }
}
