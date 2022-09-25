using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCONS.APP1.BOOKSTORE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название книги");
            string namebook = Console.ReadLine();
            Console.WriteLine("Введите автора");
            string namewriter = Console.ReadLine();
            Console.WriteLine("Введите максимальную цену покупки книги в рублях");
            int maxPrice, maxA, Price;
            maxPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное количество попыток поиска книги");
            maxA = int.Parse(Console.ReadLine());
            for (int i = 0; i < maxA; i++)
            {
                Console.WriteLine("Идем в книжный магазин!"); // заменяем реальное действие на вывод текста, затем его подтверждаем.
                Console.WriteLine("Когда будете в магазине нажмите ENTER");
                Console.ReadLine();
                Console.WriteLine("Теперь ищем " + namebook + " автора " + namewriter);
                Console.WriteLine("Книга есть в наличии? да/нет)"); // вместо подключения базы данных с наличием книг упрощаем поиск ответом
                string availability = Console.ReadLine();
                if (availability == "да")
                {
                    Console.WriteLine("Введите цену книги");
                    Price = int.Parse(Console.ReadLine());
                    if (Price <= maxPrice)
                    {
                        Console.WriteLine("Отлично! Покупаем книгу!");
                        return;
                    }
                    else if (Price > maxPrice)
                    {
                        Console.WriteLine("Не хватает денег.");
                    }
                }
                else
                {
                    Console.WriteLine("Очень жаль, что книги нет");
                }
            }
            Console.WriteLine("К сожалению, нам не удалось купить книгу");
        }
    }
}
