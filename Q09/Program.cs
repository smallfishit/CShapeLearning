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

            //先列出最大值的平方根以下的所有質數(以上的可忽略)

            //先列出基本的質數
            List<int> checkPrimeList = new List<int>() { 2, 3, 5, 7 };

            //最大值的平方根
            int sqrt = (int)Math.Sqrt(maxmum);

            int i = 0;
            try
            {
                PrimeAnalysis analysis = new PrimeAnalysis();
                //取得所有質數，從10開始取
                for (i = 10; i <= sqrt; i++)
                {
                    if (analysis.IsPrime(i, checkPrimeList))
                    {
                        checkPrimeList.Add(i);
                    }
                }

                //現在開始正式取質數
                List<int> primeList = new List<int>();
                for (i = minimum; i <= maxmum; i++)
                {
                    if (analysis.IsPrime(i, checkPrimeList))
                    {
                        primeList.Add(i);
                    }
                }
                Console.Write($"{minimum}~{maxmum}之間的質數為：");
                for (i = 0; i < primeList.Count; i++)
                {
                    if (i > 0)
                    {
                        Console.Write($", ");
                    }
                    Console.Write($"{primeList[i]}");
                }
                Console.Write($" 共{primeList.Count}個質數");
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
