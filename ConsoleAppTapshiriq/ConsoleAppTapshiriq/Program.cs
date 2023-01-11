using System.Diagnostics.CodeAnalysis;

namespace ConsoleAppTapshiriq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Evtapshiriq1();
        }
        static void Evtapshiriq1()
        {
            Console.Write("a:");

            string inputValue = Console.ReadLine();
            int a;
            if (int.TryParse(inputValue, out a) != true)
            {
                Console.WriteLine("eded dogru deyil");
                //goto Label1;
            }
            if (a >= 1000 && a < 10000)
            {
                int summ = 0;
                while (a > 0)
                {
                    summ = summ + a % 10;
                    a = a / 10;
                }
                Console.WriteLine(summ);
            }
            else
            {
                Console.WriteLine("eded bu parcada olmalidir [1000,9999]!");
                //goto Label1;
            }
        }
    }
}