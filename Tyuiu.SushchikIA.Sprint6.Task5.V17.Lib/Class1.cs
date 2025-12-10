using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SushchikIA.Sprint6.Task5.V17.Lib
{
    public class DataService : ISprint6Task5V17
    {
        public double[] LoadFromDataFile(string path)
        {
            double[] array = { -17.0, -14.32, -7.84, -1.57, -3.64, -13.26, -8.91, -17.77, -9.0, -1.49, -7.0 };
            return array;
        }
    }
}
