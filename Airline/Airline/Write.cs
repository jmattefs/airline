using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Airline
{
    class Write
    {
        public void writeInfoToManifest(string one)
        {

            File.AppendAllText(@"c:\users\joseph\desktop\manifest.txt", one + Environment.NewLine);
            //place holder variables from rps
        }
    }
}
