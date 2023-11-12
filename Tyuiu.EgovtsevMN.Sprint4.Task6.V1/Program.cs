using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.EgovtsevMN.Sprint4.Task6.V1.Lib;

namespace Tyuiu.EgovtsevMN.Sprint4.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Еговцев М.Н. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Еговцев Максим Николаевич | АСОиУб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных Яблоко, Банан, Вишня, Драгонфрут, Бузина    *");
            Console.WriteLine("* Инжир, Виноград* используя класс Array подсчитайте количество элементов,*");
            Console.WriteLine("* длина которых больше 6.                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] fruitArray = { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < fruitArray.Length; i++)
            {
                Console.Write($"{fruitArray[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");

            var res = ds.Calculate(fruitArray);
            string result = string.Join(", ", res);
            Console.Write("Элементы, длина которых больше 6 символов:\n" + result);

            Console.ReadLine();
        }
    }
}
