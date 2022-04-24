using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            //直接列出所有迴文數
            int index = 0;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if(index > 0)
                            Console.Write(", ");
                        Console.Write($"{i}{j}{k}{j}{i}");
                        index++;
                    }
                }
            }
            Console.Write($" 共{index}個迴文數");

            Console.WriteLine();
            Console.WriteLine("請輸入任意鍵結束!");
            Console.ReadKey();
        }
    }
}
