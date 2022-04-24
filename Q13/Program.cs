using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            //行列數
            int count = 5;
            Console.WriteLine("實心的矩形");
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("空心的矩形");
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if(i > 0 && i < count-1)
                    {
                        if(j == 0 || j == count-1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("請輸入任意鍵結束!");
            Console.ReadKey();
        }
    }
}
