using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace สอบปฏิบัติข้อ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = a, y = b;

            if ( x == y)
            {
                Console.WriteLine(x);
            }
            else
            {
                while (x != y)
                {
                    if (x < y)
                    {
                        x = x + a;
                    }
                    else
                    {
                        y = y + b;
                    }                   
                }
                Console.WriteLine(x);
            }                      
            Console.ReadLine();

            

        }
    }
}
