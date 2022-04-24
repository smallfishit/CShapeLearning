using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q09
{
    class Program
    {
        static void Main(string[] args)
        {
            int minimum = 101;
            int maxmum = 200;

            List<int> narcissisticList = new List<int>();
            try
            {
                PrimeAnalysis analysis = new PrimeAnalysis();
                for (int i = minimum; i <= maxmum; i++)
                {
                    if (analysis.IsPrime(i))
                    {
                        narcissisticList.Add(i);
                    }
                }
                Console.Write($"{minimum}~{maxmum}之間的質數為：");
                for (int i = 0; i < narcissisticList.Count; i++)
                {
                    if (i > 0)
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
