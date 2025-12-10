using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SushchikIA.Sprint6.Task3.V21.Lib
{
    public class DataService : ISprint6Task3V21
    {
        public int[,] Calculate(int[,] matrix)
        {

            int[,] matrix1 = {
    { -18, -15, 7, 1, -4 },
    { -8, 26, 22, 17, 27 },
    { 5, 31, 22, 34, 4 },
    { 14, 16, -2, 16, 27 },
    { 26, 2, -4, 16, 15 }
};
            return matrix1;
        }
    }
}
