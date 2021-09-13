using System;
using System.IO;

namespace UnixConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tools tools = new Tools();

            if (args[0] == "cat")
            {
                Console.WriteLine(tools.Cat(args[1]));
            }

            if (args[0] == "wc" && args[1] == "-l")
            {
                Console.WriteLine(tools.WcL(args[2]));
            }

            if (args[0] == "wc" && args[1] == "-w")
            {
                Console.WriteLine(tools.WcW(args[2]));
            }

            if (args[0] == "grep")
            {
                foreach (var line in tools.Grep(args[2], args[1]))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
