using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    internal class Test
    {
        public static void Main()
        {
            string message;
            Console.WriteLine("Enter massage to reverse:");
            message = Console.ReadLine();
            
            Utils.Reverse(ref message); //Преобразовывает текст задом на перед
            
            Console.WriteLine(message);
        }
    }
}
