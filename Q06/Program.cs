using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"請輸入1~10之間的數字：");
            string text = Console.ReadLine();
            int number = 0;
            try
            { 
                if (Int32.TryParse(text, out number))
                {
                    FactorialAnalysis analysis = new FactorialAnalysis();
                    int result = analysis.GetFactorialSum(number);
                    Console.WriteLine($"計算結果為：{result}");
                }
                else
                {
                    Console.WriteLine("輸入有誤，直接結束!");
                    return;
                }
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
