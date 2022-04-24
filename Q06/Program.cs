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
            int number = 10;
            try
            {
                FactorialAnalysis analysis = new FactorialAnalysis();
                int result = analysis.GetFactorial(number);
                Console.WriteLine($"{number}! = {result}");
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
