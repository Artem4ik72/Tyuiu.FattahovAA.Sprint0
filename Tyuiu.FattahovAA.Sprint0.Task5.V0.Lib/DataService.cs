namespace Tyuiu.FattahovAA.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int x, int y)
        {
            return x + y;
        }

        public static int Subtraction(int x, int y)
        {
            return x - y;
        }

        public static int Multiplication(int x, int y)
        {
            return x * y;
        }

        public static int Division(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Ошибка вычисления. На ноль делить нельзя");
                return -1;
            }
            else
            {
                return x / y;
            }
        }
    }
}
