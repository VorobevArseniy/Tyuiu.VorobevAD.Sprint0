namespace Tyuiu.VorobevAD.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Substraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Division(int a, int b)
        {
            if(b != 0) { 
            return a / b;
            }
            else
            {
                Console.WriteLine("Nah nah nah this shit cannot be real");
                return -1;
            }
        }
    }
}
