using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Airline
{
    public class Read
    {
        public void readInfoFromManifest11()
        {

            using (StreamReader reader = new StreamReader(@".\manifest11.txt"))
            {
                reader.ReadToEnd();
                reader.Close();
                reader.Dispose();

            }
        }
        public void readInfoFromManifest12()
        {

            using (StreamReader reader = new StreamReader(@".\manifest12.txt"))
            {
                reader.ReadToEnd();
                reader.Close();
                reader.Dispose();

            }
        }
        public void readInfoFromManifest101()
        {

            using (StreamReader reader = new StreamReader(@".\manifest101.txt"))
            {
                reader.ReadToEnd();
                reader.Close();
                reader.Dispose();

            }
        }
        public void readInfoFromManifest102()
        {

            using (StreamReader reader = new StreamReader(@".\manifest102.txt"))
            {
                reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
            }
        }
        public void readInfoFromManifest1001()
        {

            using (StreamReader reader = new StreamReader(@".\manifest1001.txt"))
            {
                reader.ReadToEnd();
                reader.Close();
                reader.Dispose();

            }
        }
        public void readInfoFromManifest1002()
        {

            using (StreamReader reader = new StreamReader(@".\manifest1002.txt"))
            {
                reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
            }
        }

    }
}
