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
            List<UserData> list = new List<UserData>();
            for(int i=0;i<3;i++)
            {
                Console.Write($"請輸入第{i + 1}個人的年齡(整數)：");
                string text = Console.ReadLine();
                int number = 0;
                if(Int32.TryParse(text, out number))
                {
                    UserData data = new UserData();
                    switch(i)
                    {
                        case 0:
                            data.Name = "小明";
                            break;
                        case 1:
                            data.Name = "小華";
                            break;
                        case 2:
                            data.Name = "小英";
                            break;
                    }
                    data.Age = number;
                    list.Add(data);
                }
                else
                {
                    Console.WriteLine("輸入有誤，直接結束!");
                    return;
                }
            }
            MiddleNumber middleNumber = new MiddleNumber();
            UserData middle = middleNumber.GetMiddleNumber(list[0], list[1], list[2]);
            Console.WriteLine($"中間的數為：{middle.Age}");

            Console.WriteLine();
            Console.WriteLine("請輸入任意鍵結束!");
            Console.ReadKey();
        }
    }
}
