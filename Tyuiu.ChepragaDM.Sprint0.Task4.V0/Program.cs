using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ChepragaDM.Sprint0.Task4.V0.Lib;

namespace Tyuiu.ChepragaDM.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(10, 10));
            Console.WriteLine(DataService.Substraction(8, 2));
            Console.WriteLine(DataService.Multiplication(6, 7));
            Console.WriteLine(DataService.Division(100, 10));
            Console.ReadKey();
        }
    }
}
