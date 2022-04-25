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
            T[] sortArray = InsertSortArray(array);
            return sortArray[1];
        }

        /// <summary>
        /// 使用插入排序法
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="arr">泛型的陣列</param>
        /// <returns></returns>
        static T[] InsertSortArray<T>(T[] arr) where T : IComparable
        {
            int length = arr.Length;
            int i, j;
            T key;
            for (i = 1; i != length; ++i)
            {
                key = arr[i];
                j = i - 1;
                while ((j >= 0) && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

        /// <summary>
        /// 交換
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="f1">參數1</param>
        /// <param name="f2">參數2</param>
        static void Swap<T>(ref T f1, ref T f2)
        {
            T temp = f1;
            f1 = f2;
            f2 = temp;
        }

    }
}
