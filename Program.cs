using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite 3 números: ");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c && b < c)
            {
                Console.WriteLine(a + ", " + b + ", " + c);
            } else if (a < b && a < c && c < b)
            {
                Console.WriteLine(a + ", " + c + ", " + ", " + b);
            } else if (b < a && b < c && a < c)
            {
                Console.WriteLine(b + ", " + a + ", " + c);
            }else if (b < a && b < c && c < a)
            {
                Console.WriteLine(b + ", " + c + ", " + a);
            }else if (c < a && c < b && a < b)
            {
                Console.WriteLine(c + ", " + b + ", " + a);
            }else if (c < a && c < b && b < a)
            {
                Console.WriteLine(c + ", " + b + ", " + a);
            }
                Console.ReadKey();
            }
        }
    }

