using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            //行列數
            int count = 5;
            Console.WriteLine("第1種三角形");
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (count > i + j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("第2種三角形");
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (j >= i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("第3種三角形");
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("第4種三角形");
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (count <= j + i + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("第5種三角形");
            for (int i = 0; i < count; i++)
            {
                string line = "";
                for (int j = 0; j < count; j++)
                {
                    if(j == 0)
                    {
                        line += "*";
                    }
                    else if(j <= i)
                    {
                        line = "*" + line + "*";
                    }
                    else
                    {
                        line = " " + line + " ";
                    }
                }
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine("第6種三角形");
            for (int i = 0; i < count; i++)
            {
                string line = "";
                for (int j = 0; j < count; j++)
                {
                    if (j == 0)
                    {
                        line += "*";
                    }
                    else if (count - j <= i)
                    {
                        line = " " + line + " ";
                    }
                    else
                    {
                        line = "*" + line + "*";
                    }
                }
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine("請輸入任意鍵結束!");
            Console.ReadKey();
        }
    }
}
