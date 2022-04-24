using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q09
{ 
    public class NarcissisticAnalysis
    {
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
                squareSum += (int)Math.Pow(tempNum % 10, 3);
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
