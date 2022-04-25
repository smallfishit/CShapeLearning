using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04
{
    public class MininumNumber
    {
        public T GetMininumNumber<T>(T number1, T number2, T number3) where T : IComparable
        {
            T min = number1;
            if (min.CompareTo(number2) > 0)
                min = number2;
            if (min.CompareTo(number3) > 0)
                min = number3;
            return min;
        }
    }
}
