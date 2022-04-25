using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q09.Test
{
    /// <summary>質數資料</summary>
    public class PrimeTest2Data
    {
        /// <summary>要判斷的數字</summary>
        public int number { get; set; }
        /// <summary>質數的列表</summary>
        public List<int> primeList { get; set; }
        /// <summary>預期的質數判斷</summary>
        public bool isPrime { get; set; }
        /// <summary>預期的文字顯示</summary>
        public string message { get; set; }


        /// <summary>基本的建構子</summary>
        public PrimeTest2Data()
        {
            number = 0;
            primeList = new List<int>();
            isPrime = false;
            message = string.Empty;
        }

        /// <summary>
        /// 載入開始結束時間的建構子
        /// </summary>
        /// <param name="number">要判斷的數字</param>
        /// <param name="primeList">質數的列表</param>
        /// <param name="isPrime">預期的質數判斷</param>
        /// <param name="message">預期的文字顯示</param>
        public PrimeTest2Data(int number, List<int> primeList, bool isPrime, string message = "")
        {
            this.number = number;
            this.primeList = primeList;
            this.isPrime = isPrime;
            this.message = message;
        }
    }
}
