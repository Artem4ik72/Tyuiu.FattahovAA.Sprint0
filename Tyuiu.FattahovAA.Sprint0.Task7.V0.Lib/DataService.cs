namespace Tyuiu.FattahovAA.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] intsOne, int[] intsTwo)
        {
            int[] result = new int[5];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = intsOne[i] + intsTwo[i];
            }
            return result;
        }
    }
}
