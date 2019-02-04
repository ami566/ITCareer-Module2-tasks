using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16system
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            var num2 = Convert.ToInt32(num1, 16);
            Console.WriteLine(num2);
        }
    }
}
