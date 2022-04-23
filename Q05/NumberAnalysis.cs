using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05
{
    public class NumberAnalysis
    {
        /// <summary>取得被3整除，但不能被5整除的數字</summary>
        public List<int> GetDevideThreeNotDevideFive(int number)
        {
            List<int> result = new List<int>();
            if (number < 1 || number > 100)
            {
                throw new Exception("請輸入1~100的正整數");
            }

            for(int i=1;i<=number;i++)
            {
                if (i % 3 == 0)
                {
                    if(i % 5 != 0)
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
    }
}
