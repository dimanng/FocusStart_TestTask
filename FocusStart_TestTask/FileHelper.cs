using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusStart_TestTask
{
    class FileHelper
    {
        public static void WriteLinesToFile(ArrayList mainList, string pathOut)
        {
            Console.WriteLine(pathOut);
            using (StreamWriter sw = new StreamWriter(pathOut, true))
            {
                foreach (object line in mainList)
                {
                    sw.WriteLine(line);
                    Console.WriteLine(line);
                }
            }
        }

        public static ArrayList ReadLinesFromFile(string e)
        {
            Console.WriteLine(e);
            ArrayList str = new ArrayList();
            using (StreamReader sr = new StreamReader(e))
            {
                string line = "";
                while (line != null)
                {
                    line = sr.ReadLine();

                    if (line == null)
                    {
                        break;
                    }
                    Console.WriteLine(line);
                    str.Add(line);
                }
            }
            return str;
        }


    }
}
