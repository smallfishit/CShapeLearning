using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> list = new List<float>();
            for(int i=0;i<3;i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                string text = Console.ReadLine();
                float number = 0;
                if(float.TryParse(text, out number))
                {
                    list.Add(number);
                }
                else
                {
                    Console.WriteLine("輸入有誤，直接結束!");
                    return;
                }
            }
            MiddleNumber middleNumber = new MiddleNumber();
            float middle = middleNumber.GetMiddleNumber(list[0], list[1], list[2]);
            Console.WriteLine($"中間的數為：{middle}");

            Console.WriteLine();
            Console.WriteLine("請輸入任意鍵結束!");
            Console.ReadKey();
        }
    }
}
