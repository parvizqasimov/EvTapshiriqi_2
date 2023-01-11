using System.Diagnostics.CodeAnalysis;

namespace ConsoleAppTapshiriq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Evtapshiriq1 ();
            // Evtapshiriq2 ();
            //Evtapshiriq3 ();
            //Evtapshiriq4();

        }
        static void Evtapshiriq1()
        {
        Label1:
            Console.Write("a:");
            string inputValue = Console.ReadLine();
            int a;
            if (int.TryParse(inputValue, out a) != true)
            {
                Console.WriteLine("eded dogru deyil");
                goto Label1;
            }
            if (a < 1000 || a > 10000)
            {
                Console.WriteLine("eded bu parcada olmalidir [1000,9999]!");
                goto Label1;
            }
                int summ = 0;
                while (a > 0)
                {
                    summ = summ + a % 10;
                    a = a / 10;
                }
                Console.WriteLine(summ);                    
         
        }
        static void Evtapshiriq2()
        {
        /*
         verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3
         */
        Label1:
            Console.Write("a:");
            string inputValue = Console.ReadLine();
            int a;
            if (int.TryParse(inputValue, out a) != true)
            {
                Console.WriteLine("eded dogru deyil");
                goto Label1;
            }
            if (a < 100000 || a > 1000000)
            {
                Console.WriteLine("eded bu parcada olmalidir [100000,999999]!");
                goto Label1;
            }
            int summ = 0;
            a = a / 1000;
            while (a > 0)
            {
                summ = summ + a % 10;
                a = a / 10;
            }
            Console.WriteLine(summ);

        }
        static void Evtapshiriq3()
        {
        /*
         verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi
         */
        Label1:
            Console.Write("a:");
            string inputValue = Console.ReadLine();
            int a;
            if (int.TryParse(inputValue, out a) != true)
            {
                Console.WriteLine("eded dogru deyil");
                goto Label1;
            }
            if (a < 100000000 || a > 1000000000)
            {
                Console.WriteLine("eded bu parcada olmalidir [100000000,999999999]!");
                goto Label1;
            }
            int summ = 0;
            a = a / 1000;
            a= a % 1000;
            while (a > 0)
            {
                summ = summ + a % 10;
                a = a / 10;
            }
            Console.WriteLine(summ);

        }
        static void Evtapshiriq4()
        {
        /*
         verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
         */
        Label1:
            Console.Write("a:");
            string inputValue = Console.ReadLine();
            int a;
            if (int.TryParse(inputValue, out a) != true)
            {
                Console.WriteLine("eded dogru deyil");
                goto Label1;
            }
            if (a < 10000 || a > 100000)
            {
                Console.WriteLine("eded bu parcada olmalidir [10000,99999]!");
                goto Label1;
            }
            int summ ,ilkeded,soneded;
            soneded = a %10;
            ilkeded= a /10000;
            summ = (soneded + ilkeded) * (soneded + ilkeded);
            
            Console.WriteLine(summ);

        }
        static void Evtapshiriq4()
        {
        /*
         verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
         */
        Label1:
            Console.Write("a:");
            string inputValue = Console.ReadLine();
            int a;
            if (int.TryParse(inputValue, out a) != true)
            {
                Console.WriteLine("eded dogru deyil");
                goto Label1;
            }
            if (a < 10000 || a > 100000)
            {
                Console.WriteLine("eded bu parcada olmalidir [10000,99999]!");
                goto Label1;
            }
            int summ, ilkeded, soneded;
            soneded = a % 10;
            ilkeded = a / 10000;
            summ = (soneded + ilkeded) * (soneded + ilkeded);

            Console.WriteLine(summ);

        }
    }
}