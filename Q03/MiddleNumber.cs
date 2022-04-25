using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03
{
    public class MiddleNumber
    {
        public T GetMiddleNumber<T>(T number1, T number2, T number3) where T : IComparable
        {
            T[] array = new T[] { number1, number2, number3 };
            T min = number1;
            T max = number1;
            T mid = number1;
            if (min.CompareTo(number2) > 0)
                min = number2;
            if (max.CompareTo(number2) < 0)
                max = number2;
            if (min.CompareTo(number3) > 0)
                min = number3;
            if (max.CompareTo(number3) < 0)
                max = number3;
            for(int i=0;i<array.Length;i++)
            {
                if(array[i].Equals(min) || array[i].Equals(max))
                { }
                else
                {
                    mid = array[i];
                    break;
                }
            }
            return mid;
        }
    }
}
