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
            PalindromeAnalysis analysis = new PalindromeAnalysis();

            try
            {
                List<int> palindromeList = analysis.GetAllFivePalindrome();
                for (int i = 0; i < palindromeList.Count; i++)
                {
                    if (i > 0)
                    {
                        Console.Write($", ");
                    }
                    Console.Write(palindromeList[i]);
            }
                Console.Write($" 共{palindromeList.Count}個迴文數");
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
