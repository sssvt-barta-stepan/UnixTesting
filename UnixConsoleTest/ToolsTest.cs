using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UnixConsole;

namespace UnixConsoleTest
{
    public class ToolsTest
    {
        private Tools tools = new Tools();

        public void CatTest()
        {
            string filename = @"C:\Users\dogik\Desktop\prg\UnitTesting\UnixConsole\bin\Debug\net5.0\myfile.txt";
            string expect = "viktor traktor. viktor traktor.\r\nviktor traktor. viktor traktor.";
            string result = tools.Cat(filename);
            Console.Write("testing method cat: ");
            Console.WriteLine(result == expect ? "OK" : "NOK");
        }

        public void WcLtest()
        {
            string filename = @"C:\Users\dogik\Desktop\prg\UnitTesting\UnixConsole\bin\Debug\net5.0\myfile.txt";
            int expect = 2;
            int result = tools.WcL(filename);
            Console.Write("testing method wc -l: ");
            Console.WriteLine(result == expect ? "OK" : "NOK");
        }

        public void WcWtest()
        {
            string filename = @"C:\Users\dogik\Desktop\prg\UnitTesting\UnixConsole\bin\Debug\net5.0\myfile.txt";
            int expect = 8;
            int result = tools.WcW(filename);
            Console.Write("testing method wc -w: ");
            Console.WriteLine(result == expect ? "OK" : "NOK");
        }

        public void GrepTest()
        {
            string filename = @"C:\Users\dogik\Desktop\prg\UnitTesting\UnixConsole\bin\Debug\net5.0\myfile.txt";
            string searchText = "viktor";
            var expect = new List<string>();
            expect.Add("viktor traktor. viktor traktor.");
            expect.Add("viktor traktor. viktor traktor.");


            List<string> result = new List<string>();
            result = tools.Grep(filename, searchText);
            var testingResult = expect.SequenceEqual(result) ? "OK" : "NOK";
            Console.WriteLine($"testing method grep: {testingResult}");
        }
    }
}
