using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05.Test
{
    /// <summary>數字計算測試資料</summary>
    public class NumberTestData
    {
        /// <summary>輸入的數字</summary>
        public int number { get; set; }
        /// <summary>結果陣列</summary>
        public List<int> resultList { get; set; }


        /// <summary>基本的建構子</summary>
        public NumberTestData()
        {
            number = 0;
            resultList = new List<int>();
        }

        /// <summary>
        /// 載入資料的建構子
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="resultList">氣溫</param>
        public NumberTestData(int number, List<int> resultList)
        {
            this.number = number;
            this.resultList = resultList;
        }
    }
}
