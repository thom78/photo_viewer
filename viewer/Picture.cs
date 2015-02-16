using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace viewer
{
    public class Picture : IComparable<Picture>
    {
        #region Properties

        [XmlElement(ElementName="Chemin")]
        public String picturePath { get; set; }

        [XmlElement(ElementName = "Nom")]
        public String Name { get; set; }

        [XmlElement(ElementName = "Rating")]
        public Int32 Rate { get; set; }

        [XmlElement(ElementName = "Commentaire")]
        public String Comment { get; set; }

        [XmlElement(ElementName = "Date")]
        public String Date { get; set; }

        [XmlIgnore]
        public Image Image;

        #endregion Properties

        #region Constructor(s)
        public Picture() { }
        public Picture(Image im,String path, String Name, Int32 rate, String comment, String date, Album album)
        {
            this.picturePath = path;
            this.Image = im;
            this.Name = Name;
            this.Rate = rate;
            this.Comment = comment;
            this.Date = date;

            //Les photos sont ajoutées dans l'album spécifié en paramètre, si elles n'existent pas déjà dedans.
            if (!album.Pictures.Exists(a=>a.picturePath==path))
            {
                album.Pictures.Add(this);
            }
        }

        #endregion Constructor(s)

        #region Method_Sort

        int IComparable<Picture>.CompareTo(Picture other)
        {
            return this.Name.CompareTo(other.Name);
        }

        #endregion Method_Sort
        
        //Inutile
        public void AddPicture()
        {
            Program.Pellicule.Pictures.Add(this);
        }
    }
}
