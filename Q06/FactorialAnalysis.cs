using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06
{ 
    public class FactorialAnalysis
    {
        public int GetFactorial(int number)
        {
            if (number < 0)
            {
                throw new Exception("階乘數字必須為0以上的整數");
            }

            //這裡使用遞迴
            if (number == 0 || number == 1)
                return 1;
            return number * GetFactorial(number - 1);
        }
    }
}
