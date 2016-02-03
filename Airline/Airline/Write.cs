using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Airline
{
    public class Write
    {
        public void writeInfoToManifest11(string one)
        {
            File.AppendAllText(@"c:\manifest11.txt", one + Environment.NewLine);
        }
        public void writeInfoToManifest12(string one)
        {
            File.AppendAllText(@"c:\manifest12.txt", one + Environment.NewLine);
        }
        public void writeInfoToManifest101(string one)
        {
            File.AppendAllText(@"c:\manifest101.txt", one + Environment.NewLine);
        }
        public void writeInfoToManifest102(string one)
        {
            File.AppendAllText(@"c:\manifest102.txt", one + Environment.NewLine);
        }
        public void writeInfoToManifest1001(string one)
        {
            File.AppendAllText(@"c:\manifest1001.txt", one + Environment.NewLine);
        }
        public void writeInfoToManifest1002(string one)
        {
            File.AppendAllText(@"c:\manifest1002.txt", one + Environment.NewLine);
        }
        public void manifestHeader11()
        {
            string header;
            string header1;
            header1 = "|-----------Flight 11-----------|";
            header = "|--------Name---------|---DOB---|";
            File.WriteAllText(@"c:\manifest11.txt", header1 + Environment.NewLine + header + Environment.NewLine);
        }
        public void manifestHeader12()
        {
            string header;
            string header1;
            header1 = "|-----------Flight 12-----------|";
            header = "|--------Name---------|---DOB---|";
            File.WriteAllText(@"c:\manifest12.txt", header1 + Environment.NewLine + header + Environment.NewLine);
        }
        public void manifestHeader102()
        {
            string header;
            string header1;
            header1 = "|----------Flight 102-----------|";
            header = "|--------Name---------|---DOB---|";
            File.WriteAllText(@"c:\manifest102.txt", header1 + Environment.NewLine + header + Environment.NewLine);
        }
        public void manifestHeader101()
        {
            string header;
            string header1;
            header1 = "|----------Flight 101-----------|";
            header = "|--------Name---------|---DOB---|";
            File.WriteAllText(@"c:\manifest101.txt", header1 + Environment.NewLine + header + Environment.NewLine);
        }
        public void manifestHeader1002()
        {
            string header;
            string header1;
            header1 = "|----------Flight 1002----------|";
            header = "|--------Name---------|---DOB---|";
            File.WriteAllText(@"c:\manifest1002.txt", header1 + Environment.NewLine + header + Environment.NewLine);
        }
        public void manifestHeader1001()
        {
            string header;
            string header1;
            header1 = "|---------Flight 1001-----------|";
            header = "|--------Name---------|---DOB---|";
            File.WriteAllText(@"c:\manifest1001.txt", header1 + Environment.NewLine + header + Environment.NewLine);
        }
        public void clearManifest11()
        {
            File.WriteAllText(@"c:\manifest11.txt", string.Empty);
        }
        public void clearManifest12()
        {
            File.WriteAllText(@"c:\manifest12.txt", string.Empty);
        }
        public void clearManifest101()
        {
            File.WriteAllText(@"c:\manifest101.txt", string.Empty);
        }
        public void clearManifest102()
        {
            File.WriteAllText(@"c:\manifest102.txt", string.Empty);
        }
        public void clearManifest1001()
        {
            File.WriteAllText(@"c:\manifest1001.txt", string.Empty);
        }
        public void clearManifest1002()
        {
            File.WriteAllText(@"c:\manifest1002.txt", string.Empty);
        }
    }
}
