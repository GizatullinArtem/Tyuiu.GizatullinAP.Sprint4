using Tyuiu.GizatullinAP.Sprint4.Task4.V27.Lib;

namespace Tyuiu.GizatullinAP.Sprint4.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] a = new int[5, 5] {
                { 4, 3, 9, 2, 2 },
                { 8, 4, 1, 4, 3 },
                { 3, 9, 2, 2, 5 },
                { 4, 6, 8, 5, 6 },
                { 1, 5, 2, 2, 5 }
            };

            var r = ds.Calculate(A);
            Assert.AreEqual(r, 49);
        }
    }
}