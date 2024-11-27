using Tyuiu.GizatullinAP.Sprint4.Task7.V1.Lib;

namespace Tyuiu.GizatullinAP.Sprint4.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            string value = "135792468";

            int res = ds.Calculate(n, m, value);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}