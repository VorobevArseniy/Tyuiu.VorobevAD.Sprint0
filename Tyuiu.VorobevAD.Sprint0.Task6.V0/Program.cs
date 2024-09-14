using Tyuiu.VorobevAD.Sprint0.Task6.V0.Lib;

namespace Tyuiu.VorobevAD.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("сумма бла бла бла..." + DataService.AdditionArray(arraynums));
            Console.WriteLine("сумма бла бла бла..." + DataService.SubstractionArray(arraynums));
            Console.WriteLine("сумма бла бла бла..." + DataService.MultiplicatinArray(arraynums));
        }
    }
}
