using tyuiu.cources.programming.interfaces;
namespace Tyuiu.GizatullinAP.Sprint4.Task6.V10.Lib
{
    public class DataService 
    {
        public string[] Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length < 7);
            return mas;
        }
    }
}