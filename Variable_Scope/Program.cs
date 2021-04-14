using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Variable_Scope
{
    class Program
    {
        static void Write()
        {
            string myString = "String defined in Write()";
            WriteLine("Now in Write()");
            WriteLine($"myString = {myString}");
        }
        static void Main(string[] args)
        {
            string myString = "String defined in Main()";
            Write();
            WriteLine("\nNow in Main()");
            WriteLine($"myString = {myString}");
            ReadKey();
        }
    }
}