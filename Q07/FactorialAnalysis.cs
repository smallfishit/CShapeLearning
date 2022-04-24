using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q07
{
    public class FactorialAnalysis
    {
        private int getFactorial(int number)
        {
            if (number < 0)
            {
                throw new Exception("階乘數字必須為0以上的整數");
            }

            //這裡使用迴圈
            int num = 1;
            for(int i=2;i<=number;i++)
            {
                num *= i;
            }
            return num;
        }

        public int GetFactorialSum(int number)
        {
            //限制只能1到10的數字
            if(number < 1 || number > 10)
            {
                throw new Exception("只接受1~10之間的正整數");
            }

            int num = 0;
            for(int i=1;i<=number;i++)
            {
                num += getFactorial(i);
            }
            return num;
        }
    }
}
