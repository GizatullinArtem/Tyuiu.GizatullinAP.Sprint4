using Tyuiu.GizatullinAP.Sprint4.Task4.V27.Lib;

namespace Tyuiu.GizatullinAP.Sprint4.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Гизатуллин А. П. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Гизатуллин Артём Павлович  | ИСПб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 9.                          *");
            Console.WriteLine("* Найдите сумму нечетных элементов массива.                               *");
            Console.WriteLine("* 4, 3, 9, 2, 2,                                                          *");
            Console.WriteLine("* 8, 4, 1, 4, 3,                                                          *");
            Console.WriteLine("* 3, 9, 2, 2, 5,                                                          *");
            Console.WriteLine("* 4, 6, 8, 5, 6,                                                          *");
            Console.WriteLine("* 1, 5, 2, 2, 5,                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int[,] A = new int[5, 5] {
                { 4, 3, 9, 2, 2 },
                { 8, 4, 1, 4, 3 },
                { 3, 9, 2, 2, 5 },
                { 4, 6, 8, 5, 6 },
                { 1, 5, 2, 2, 5 }
            };

            DataService DS = new DataService();
            var Res = DS.Calculate(A);
            Console.WriteLine("РЕЗУЛЬТАТ: " + Res);
            Console.ReadKey();
        }
    }
}