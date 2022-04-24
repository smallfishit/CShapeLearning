using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if(j > 1)
                    {
                        Console.Write("  ");
                    }
                    string space = "";
                    if (i*j < 10)
                    {
                        space = " ";
                    }
                    Console.Write($"{i}x{j}={space}{i * j}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("請輸入任意鍵結束!");
            Console.ReadKey();
        }
    }
}
