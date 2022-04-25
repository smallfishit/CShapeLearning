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
            for (int i = 2; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>確認輸入數字是否為質數</summary>
        /// <param name="number">輸入數字</param>
        /// <param name="primeList">用來檢查的質數列表</param>
        /// <returns></returns>
        public bool IsPrime(int number, List<int> primeList)
        {
            if (number < 1)
            {
                throw new Exception("判斷質數必須為正整數");
            }

            int sqrt = (int)Math.Sqrt(number);
            for(int i=0;i<primeList.Count;i++)
            {
                int prime = primeList[i];
                if (prime > sqrt)
                {
                    break;
                }
                if(number % prime == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
