using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GizatullinAP.Sprint4.Task4.V27.Lib
{
    public class DataService : ISprint4Task4V27
    {
        public int Calculate(int[,] Matrix)
        {
            int Res = 0;
            for (int I = 0; I < Matrix.GetLength(0); I += 1)
            {
                for (int J = 0; J < Matrix.GetLength(1); J += 1)
                {
                    if (Matrix[I, J] % 2 != 0) { Res += Matrix[I, J]; }
                }
            }
            return Res;
        }
    }
}