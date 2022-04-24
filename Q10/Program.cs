using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            const string username = "1";
            const string password = "123456";

            //允許輸入次數
            const int inputCount = 3;

            int i = 0;
            for(i=0;i< inputCount; i++)
            {
                string name = "";
                string pass = "";
                Console.WriteLine($"第{i + 1}次嘗試：");
                Console.Write($"第輸入使用者名稱：");
                name = Console.ReadLine();
                Console.Write($"第輸入密碼：");
                pass = Console.ReadLine();
                if(name == username && pass == password)
                {
                    Console.WriteLine("登入成功!");
                    break;
                }
                else
                {
                    Console.WriteLine("帳號或密碼錯誤...");
                    Console.WriteLine();
                }
            }
            if(i >= inputCount)
            {
                Console.WriteLine("您已經錯誤3次，程式即將關閉!");
            }

            Console.WriteLine();
            Console.WriteLine("請輸入任意鍵結束!");
            Console.ReadKey();
        }
    }
}
