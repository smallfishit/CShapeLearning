using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q08
{ 
    public class NarcissisticAnalysis
    {
        private Dictionary<int, int> NarcissisticList { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        public NarcissisticAnalysis()
        {
            NarcissisticList = new Dictionary<int, int>();
            for(int i=0;i<10;i++)
            {
                NarcissisticList.Add(i, (int)Math.Pow(i, 3));
            }
        }

        /// <summary>確認輸入數字是否為水仙花數</summary>
        /// <param name="number">輸入數字</param>
        /// <returns></returns>
        public bool IsNarcissistic(int number)
        {
            if (number < 0)
            {
                throw new Exception("水仙花數必須為0以上的整數");
            }

            int squareSum = 0;
            int tempNum = number;
            while(tempNum > 0)
            {
                squareSum += NarcissisticList[tempNum % 10];
                tempNum /= 10;
            }
            if(squareSum == number)
            {
                return true;
            }
            return false;
        }
    }
}
