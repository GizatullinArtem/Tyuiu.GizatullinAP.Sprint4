using Tyuiu.GizatullinAP.Sprint4.Task6.V10.Lib;

namespace Tyuiu.GizatullinAP.Sprint4.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Гизатуллин А. П.  | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. Ввод с клавиатуры                             *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Гизатуллин Артём Павлович |  ИСПб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных Театр, Кино, Музей, Парк,                   *");
            Console.WriteLine("* Зоопарк, Концерт, Выставка , используя класс Array,                     *");
            Console.WriteLine("* выведите элементы массива, длина которых меньше 7 символов.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var name = new string[] { "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= name.Length - 1; i++)
            {
                Console.WriteLine(name[i]);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов длина которых < 7:");

            string[] res = ds.Calculate(name);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}