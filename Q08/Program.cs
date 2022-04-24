using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q08
{
    class Program
    {
        static void Main(string[] args)
        {
            int minimum = 101;
            int maxmum = 999;

            List<int> narcissisticList = new List<int>();
            try
            {
                NarcissisticAnalysis analysis = new NarcissisticAnalysis();
                for (int i=minimum;i<=maxmum;i++)
                {
                    if(analysis.IsNarcissistic(i))
                    {
                        narcissisticList.Add(i);
                    }
                }
                Console.Write($"3位數的水仙花數為：");
                for (int i = 0; i < narcissisticList.Count; i++)
                {
                    if(i > 0)
                    {
                        Console.Write($", ");
                    }
                    Console.Write($"{narcissisticList[i]}");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine();
            Console.WriteLine("請輸入任意鍵結束!");
            Console.ReadKey();
        }
    }
}
