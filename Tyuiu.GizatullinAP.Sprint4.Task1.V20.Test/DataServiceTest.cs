using Tyuiu.GizatullinAP.Sprint4.Task1.V20.Lib;

namespace Tyuiu.GizatullinAP.Sprint4.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 0, 4, 7, 5, 3, 9, 2, 7, 0 };
            int res = ds.Calculate(numsArray);
            int wait = 31;

            Assert.AreEqual(wait, res);
        }
    }
}