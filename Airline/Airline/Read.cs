using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Airline
{
    class Read
    {
        public void readInfoFromManifest()
        {
            string scores;
            using (StreamReader reader = new StreamReader(@"c:\users\joseph\desktop\manifest.txt"))
            {
                scores = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
                Console.WriteLine(scores); //place holder variables from rps

            }
        }

    }
}
