using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_04_01
{
    internal class Test
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int greater;
            Console.WriteLine("Please, enter first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter second number");
            y = int.Parse(Console.ReadLine());
            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);
        }
    }
}
