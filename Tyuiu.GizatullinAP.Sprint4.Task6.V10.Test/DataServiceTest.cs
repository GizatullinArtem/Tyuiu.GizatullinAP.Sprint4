
using Tyuiu.GizatullinAP.Sprint4.Task6.V10.Lib;

namespace Tyuiu.GizatullinAP.Sprint4.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest { 
        [TestMethod]
        public void ValidCalculate()
        {
            DataService dataService = new DataService(); 
            var x = new string[] { "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };
            string[] res = dataService.Calculate(x); 
            string[] wait = { "Театр", "Кино", "Музей", "Парк"};
            CollectionAssert.AreEqual(wait, res); 
        }
    }
}