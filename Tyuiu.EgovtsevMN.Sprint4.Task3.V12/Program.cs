using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.EgovtsevMN.Sprint4.Task3.V12.Lib;

namespace Tyuiu.EgovtsevMN.Sprint4.Task3.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[5, 5] { { 9, 7, 4, 9, 7 },
                                         { 5, 2, 5, 7, 6 },
                                         { 8, 3, 3, 5, 7 },
                                         { 8, 4, 2, 4, 5 },
                                         { 8, 8, 9, 5, 6 } };
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Еговцев М.Н. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Еговцев Максим Николаевич | АСОиУб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 9. Найдите минимальный      *");
            Console.WriteLine("* элемент третьем столбце массива.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mas);

            Console.WriteLine("Минимальный элемент в третьем столбце массива = " + res);
            Console.ReadKey();
        }
    }
}
