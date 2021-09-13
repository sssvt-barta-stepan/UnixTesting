using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace UnixConsole
{
    public enum CountWhat { Words, Rows }
    public class Tools
    {
        public string Cat(string filename)
        {
            //cat

            string text = File.ReadAllText(filename);
            return text;
        }
        public int WcL(string filename)
        {
            //wc -l

            int counter = 0;
            string line;

            StreamReader sr = new StreamReader(filename);

            while ((line = sr.ReadLine()) != null)
            {
                counter++;
            }
            
            sr.Close();

            return counter;
        }

        public int WcW(string filename)
        {      
            //wc -w

            string text = File.ReadAllText(filename);
            int word, l;

            l = 0;
            word = 1;

            /* loop do konce souboru */
            while (l <= text.Length - 1)
            {
                /* zjistí jestli je další znak mezera, nový řádek nebo tabulátor */
                if (text[l] == ' ' || text[l] == '\n' || text[l] == '\t')
                {
                    word++;
                }

                l++;
            }

            return word;
        }

        public List<string> Grep(string filename, string searchText)
        {
            //grep

            var lines = File.ReadLines(filename)
                .Where(line => line.Contains(searchText))
                .ToList();

            return lines;
        }

    }
}
