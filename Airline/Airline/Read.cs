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
        public void readInfoFromManifest()
        {
            string scores;
            using (StreamReader reader = new StreamReader(@"c:\manifest.txt"))
            {
                scores = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
                Console.WriteLine(scores); 

            }
        }

    }
}
