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
            //Evtapshiriq5();
            //Evtapshiriq6();
            //Evtapshiriq7();
            Evtapshiriq8();

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
        static void Evtapshiriq5()
        {
        /*
         verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
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
            if (a < 100000 || a >= 1000000)
            {
                Console.WriteLine("eded bu parcada olmalidir [100000,999999]!");
                goto Label1;
            }
            int first;
            first= a / 100000;
            a = a % 100000;
            a=a*10+first;   

            Console.WriteLine(a);

        }
        static void Evtapshiriq6()
        {
        /*
         verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et
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
            if (a < 10000000 || a >=100000000)
            {
                Console.WriteLine("eded bu parcada olmalidir [10000000,99999999]!");
                goto Label1;
            }
            a = a % 10000000;
            a = a / 10;

            Console.WriteLine(a);

        }
        static void Evtapshiriq7()
        {
        /*
         verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir
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
            if (a < 1000 || a >= 10000)
            {
                Console.WriteLine("eded bu parcada olmalidir [1000,9999]!");
                goto Label1;

                
            }
            int ters = 0, qaliq, yekun;
            while (a > 0)
            {
               qaliq = a % 10;
               ters = ters * 10 + qaliq;
               a = a / 10;

            }
            yekun = ters * 10 + 8;
            yekun = yekun + 800000;                     

            Console.WriteLine(yekun);

        }
        static void Evtapshiriq8()
        {
        /*
         Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap  
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
            if (a < 100 )
            {
                Console.WriteLine("eded en azi 3 reqemli olmalidir");
                goto Label1;
            }

            int soneded;
            soneded= a%10;
            a = a / 100;
            a=a%10;
            a=a+soneded;
            Console.WriteLine(a);

        }
    }
}