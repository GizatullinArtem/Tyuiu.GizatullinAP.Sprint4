﻿using Tyuiu.GizatullinAP.Sprint4.Task1.V20.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Гизатуллин А. П. | ИСПб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил: Гизатуллин Артём Павлович    | ИСПб-24-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 0 до 9  подсчитать произведение  *");
        Console.WriteLine("* нечетных элементов массива. 8, 0, 4, 7, 5, 3, 9, 2, 7, 0                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("***************************************************************************");

        int len;
        Console.WriteLine("Введите количество элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());


        int[] numsArray = new int[len];
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("Введите значение " + i + "Элемент массива: ");
            numsArray[i] = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine();
        Console.WriteLine("Масив: ");


        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine(numsArray[i] + "\t");
        }


        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(numsArray);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}