using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformingMars
{

    class IOManager
    {

        internal static List<String> GetContentOfFile(string fileSource)
        {
            var fileContent = new List<string>();

            var file = new FileInfo(fileSource);
            if (file.Exists)
            {
                //StreamReader sr = file.OpenText();

                StreamReader sr = new StreamReader(file.ToString(), Encoding.GetEncoding("iso-8859-1"), true);

                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    fileContent.Add(s);
                }
                sr.Close();

                return fileContent;
            }

            else
            {
                throw new FileNotFoundException();
            }
        }

        internal static void ExportToNewFile(string fileDestination, List<string> list)
        {
            var file = new FileInfo(fileDestination);
            if (file.Exists)
            {
                file.Delete();
            }
            {

                using (StreamWriter writer = new StreamWriter(file.OpenWrite()/*, Encoding.GetEncoding("iso-8859-1")*/))
                {
                    foreach (string element in list)
                    {
                        writer.WriteLine(element);
                    }
                }
            }
        }
    }
}
