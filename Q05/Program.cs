using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05
{
    class Program
    {
        static void Main(string[] args)
        {
            //每行5個數字
            int lineCount = 5;

            Console.Write("請輸入正整數：");
            string text = Console.ReadLine();
            int number = 0;
            try
            {
                if (Int32.TryParse(text, out number))
                {
                    NumberAnalysis analysis = new NumberAnalysis();
                    List<int> resultList = analysis.GetDevideThreeNotDevideFive(number);

                    int count = resultList.Count;
                    int lines = count % lineCount;
                    
                    for(int i=0;i<lines;i++)
                    {
                        for(int j=0;j<lineCount;j++)
                        {
                            int num = i * lineCount + j;
                            if (num >= count)
                            {
                                break;
                            }
                            if (j > 0)
                                Console.Write(", ");
                            Console.Write(resultList[num]);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("必須輸入整數!");
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
