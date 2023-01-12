using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization;

namespace ConsoleAppTapshiriq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Evtapshiriq1();
            //Evtapshiriq2();
            //Evtapshiriq3();
            //Evtapshiriq4();
            //Evtapshiriq5();
            //Evtapshiriq6();
            //Evtapshiriq7();
            //Evtapshiriq8();
            //Evtapshiriq9();
            //Evtapshiriqi10(); 
            //Evtapshiriq11();

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
        static void Evtapshiriq9()
        {
        /*
         9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439  
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
            if (a < 100000000 || a >= 1000000000)
            {
                Console.WriteLine("eded bu araliqda olmalidir [100000000-999999999]");
                goto Label1;
            }

            int ters = 0, son;

            while (a > 0)
            {
                son=a % 10;
                ters = ters * 10 + son;
                a/=10;
            }

            a = ters;
            ters = 0;

            int part1 = 0, part2 = 0, i = 1;

            while (a>0)
            {
                son= a%10;
                a/=10;

                if(i % 2 != 0)
                {
                    part1 = part1 * 10 + son;
                }
                
                i++;
            }

            Console.WriteLine($"Part1:{part1}");
            

        }
        static void Evtapshiriq10()
        {
        /*
         10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
        sonra cut yerde dayanlarinda bir eded duzlet,
        sonra onlari topla  
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
            if (a < 100000000 || a >= 1000000000)
            {
                Console.WriteLine("eded bu araliqda olmalidir [100000000-999999999]");
                goto Label1;
            }

            int ters = 0, son;

            while (a > 0)
            {
                son = a % 10;
                ters = ters * 10 + son;
                a /= 10;
            }

            a = ters;
            ters = 0;

            int part1 = 0, part2 = 0, i = 1;

            while (a > 0)
            {
                son = a % 10;
                a /= 10;

                if (i % 2 == 0)
                {
                    part2 = part2 * 10 + son;
                }
                else
                {
                    part1 = part1 * 10 + son;
                }
                i++;
            }

            Console.WriteLine($"Part1:{part1}");
            Console.WriteLine($"Part2:{part2}");

        }
        static void Evtapshiriq11()
        {
        /*
         11) 8 reqemli ededin reqemlerini iki -iki qruplashdir.
        Qruplarin cemini tap. Alinan cavabin axirina 99 artir.
        Sonra cavabin ozunden onun 18% ni cix;
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
            if (a < 10000000 || a >= 100000000)
            {
                Console.WriteLine("eded bu parcada olmalidir [10000000,99999999]!");
                goto Label1;
            }
            int part1, part2, part3, part4;
            double yekun;
            part1=a% 100;
            part2 = (a/100 )% 100;
            part3 = (a / 10000) % 100;
            part4 = (a / 1000000) % 100;
            a= part1+ part2+ part3+ part4;
            yekun = a * 100 + 99;
            yekun = yekun - (yekun * 18 / 100);

            Console.WriteLine(yekun);
            

        }
        static void Evtapshiriq12()
        {
        /*
         12) 2 dene 5 reqemli eded daxil et.
    I ededin reqemleri ceminin usutne II ededin reqemleri hasilini gel.
    Neticenin axirina I ededin en axiinci reqemini artir.
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
            if (a < 10000000 || a >= 100000000)
            {
                Console.WriteLine("eded bu parcada olmalidir [10000000,99999999]!");
                goto Label1;
            }
            int part1, part2, part3, part4;
            double yekun;
            part1 = a % 100;
            part2 = (a / 100) % 100;
            part3 = (a / 10000) % 100;
            part4 = (a / 1000000) % 100;
            a = part1 + part2 + part3 + part4;
            yekun = a * 100 + 99;
            yekun = yekun - (yekun * 18 / 100);

            Console.WriteLine(yekun);


        }
        static void Evtapshiriq13()
        {
        /*
         3 dene 5 reqemli eded var.
    Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
    Yekunda alian cavabin 50%-ni hemin ededin uzerine gel.
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
            if (a < 10000000 || a >= 100000000)
            {
                Console.WriteLine("eded bu parcada olmalidir [10000000,99999999]!");
                goto Label1;
            }
            

           // Console.WriteLine(yekun);


        }
    }
}