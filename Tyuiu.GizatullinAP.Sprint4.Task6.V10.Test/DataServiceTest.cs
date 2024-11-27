
using Tyuiu.GizatullinAP.Sprint4.Task6.V10.Lib;

namespace Tyuiu.GizatullinAP.Sprint4.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest { 
        [TestMethod]
        public void ValidCalculate()
        {
            DataService dataService = new DataService(); 
            var x = new string[] { "�����", "����", "�����", "����", "�������", "�������", "��������" };
            string[] res = dataService.Calculate(x); 
            string[] wait = { "�����", "����", "�����", "����"};
            CollectionAssert.AreEqual(wait, res); 
        }
    }
}