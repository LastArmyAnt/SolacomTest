using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SolacomTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SolacomTest Ran");
            Console.WriteLine("File Version is {0}", ((AssemblyFileVersionAttribute)(Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyFileVersionAttribute)))).Version);

            //a change that won't cause problems
            int test = 2;
            test = test +2;

            //Keep the console window open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
