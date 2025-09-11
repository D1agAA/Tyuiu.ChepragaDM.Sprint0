using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChepragaDM.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ChepragaDM.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a + b = " + DataService.Addition(10, 10));
            Console.WriteLine("a - b = " + DataService.Substraction(8, 2));
            Console.WriteLine("a * b = " + DataService.Multiplication(6, 7));
            Console.WriteLine("a / b = " + DataService.Division(100, 0));
            Console.ReadKey();
        }
    }
}
