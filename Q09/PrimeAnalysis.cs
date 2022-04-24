using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q09
{ 
    public class PrimeAnalysis
    {
        /// <summary>確認輸入數字是否為質數</summary>
        /// <param name="number">輸入數字</param>
        /// <returns></returns>
        public bool IsPrime(int number)
        {
            if (number < 1)
            {
                throw new Exception("判斷質數必須為正整數");
            }

            int sqrt = (int)Math.Sqrt(number);
            for(int i=2;i<=sqrt;i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
