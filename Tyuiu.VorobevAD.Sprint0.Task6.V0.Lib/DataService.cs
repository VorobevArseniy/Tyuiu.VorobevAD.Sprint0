﻿namespace Tyuiu.VorobevAD.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; ++i)
            {
                total += numbers[i];
            }
            return total;
        }

        public static object SubstractionArray(int[] numbers)
        {
            int total = 0;
            int index = 0;

            while (index < numbers.Length)
            {
                total -= numbers[index];
                index++;
            }
            return total;
        }

        public static object MultiplicatinArray(int[] numbers)
        {
            int total = 1;
            int index = 0;
            do
            {
                total *= numbers[index];
                index++;
            }
            while (index < numbers.Length);

            return total;
        }

    }
}
