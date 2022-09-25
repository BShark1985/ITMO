using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO._124_16.Leontev.Algorithm6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 24;
            int S = 0;
            int T;
            int Mid;
            int i = 1;
            for (; i <= n; i++) 
            {
                Console.WriteLine("Введите T ");
                T = int.Parse(Console.ReadLine());
                S += T;
            }
            Mid = S / (i - 1);
            Console.WriteLine("Mid = " + Mid);
        }
    }
}
