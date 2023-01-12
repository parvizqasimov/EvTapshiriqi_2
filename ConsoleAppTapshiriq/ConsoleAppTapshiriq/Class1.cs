using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTapshiriq
{
    internal class Class1
    {
        internal static void CheckValue(int a)
        {
        Label1:
            
            string inputValue = Console.ReadLine();
           
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
        }

    }
}
