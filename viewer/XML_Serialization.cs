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
        public static void save_user_data() 
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Album>));
            using (StreamWriter wr = new StreamWriter("user_data.xml"))
            {
                xs.Serialize(wr, Program.Albums);
            }
        }

        public static void load_user_data()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Album>));
        }
    }
}
