using System;
using System.IO;

namespace UnixConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ToolsTest toolsTest = new ToolsTest();
            toolsTest.CatTest();
            toolsTest.WcWtest();
            toolsTest.WcLtest();
            toolsTest.GrepTest();
        }
    }
}
