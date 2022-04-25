using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03
{
    public class MiddleNumber
    {
        /// <summary>
        /// 取得中間的數字(因為只有三個數字，排除前後就是中間數)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="number1">輸入數字1</param>
        /// <param name="number2">輸入數字2</param>
        /// <param name="number3">輸入數字3</param>
        /// <returns></returns>
        public T GetMiddleNumber1<T>(T number1, T number2, T number3) where T : IComparable
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

        /// <summary>
        /// 取得中間的數字(使用排序的方法)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="number1">輸入數字1</param>
        /// <param name="number2">輸入數字2</param>
        /// <param name="number3">輸入數字3</param>
        /// <returns></returns>
        public T GetMiddleNumber<T>(T number1, T number2, T number3) where T : IComparable
        {
            T[] array = new T[] { number1, number2, number3 };
            T[] sortArray = SelectSortArray(array);
            return sortArray[1];
        }

        /// <summary>
        /// 選擇排序法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr">輸入陣列</param>
        /// <returns></returns>
        static T[] SelectSortArray<T>(T[] arr) where T : IComparable
        {
            int length = arr.Length;
            int i, j;

            for (i = 0; i < length - 1; i++)
            {
                int min = i;
                //走訪未排序的元素
                for (j = i + 1; j < length; j++)
                {
                    //找到目前最小值
                    if (arr[j].CompareTo(arr[min]) < 0)
                    {
                        //紀錄最小值
                        min = j;
                    }
                }
                if (min != i)
                {
                    //交換兩個變數
                    Swap(ref arr[i], ref arr[min]);
                }
            }
            return arr;
        }

        /// <summary>
        /// 交換變數
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="f1">變數1</param>
        /// <param name="f2">變數2</param>
        static void Swap<T>(ref T f1, ref T f2)
        {
            (f1, f2) = (f2, f1);
        }
    }
}
