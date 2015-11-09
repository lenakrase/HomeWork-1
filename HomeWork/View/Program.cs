using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            Console.WriteLine("Задать возраст кошки");
            var cat = new Cat(Age1: Int32.Parse(Console.ReadLine()));
            var catColor = new CatColor();

            do
            {
                Console.WriteLine();
                Console.WriteLine("Имя:" + cat.Name);
                Console.WriteLine("Возраст:" + cat.Age);
                Console.WriteLine("Цвет:" + cat.CurrentColor);
                Console.WriteLine();
                Console.WriteLine("1.Задать имя");
                Console.WriteLine("2.Задать цвет");
                Console.WriteLine("3.Ударить");
                Console.WriteLine("4.Покормить");


                menu = Int32.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Введите имя:");
                        cat.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите здоровый цвет:");
                        CatColor.HeathyColor = Console.ReadLine();
                        Console.WriteLine("Введите больной цвет:");
                        CatColor.SickColor = Console.ReadLine();
                        break;
                    case 3:
                        cat.Punish();
                        break;
                    case 4:
                        cat.Feed();
                        break;

                    default:
                        Console.WriteLine("Неверный пункт меню");
                        Console.ReadKey();
                        break;
                }
            } while (menu != 0);
        }
    }
}
