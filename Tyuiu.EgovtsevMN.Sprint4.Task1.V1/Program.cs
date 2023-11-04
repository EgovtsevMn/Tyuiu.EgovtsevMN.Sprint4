using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.EgovtsevMN.Sprint4.Task1.V1.Lib;

namespace Tyuiu.EgovtsevMN.Sprint4.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил: Еговцев М. Н. | АСОиУб-23-1";
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                            *");
            Console.WriteLine("* Тема: Обработка структурных типов                                                    *");
            Console.WriteLine("* Задание #1                                                                           *");
            Console.WriteLine("* Вариант #1                                                                           *");
            Console.WriteLine("* Выполнил: Еговцев Максим Николаевич | АСОиУб-23-1                                    *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный значениями           *");
            Console.WriteLine("* с клавиатуры в диапазоне от 0 до 9 подсчитать сумму нечетных элементов массива.      *");
            Console.WriteLine("* С клавиатуры: 8, 2, 7, 5, 0, 7, 4, 7, 5, 7                                           *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");




            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите " + i + " элемент массива: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("Сумма четных элементов массива = " + ds.Calculate(arr));

            Console.ReadLine();
        }
    }
}
