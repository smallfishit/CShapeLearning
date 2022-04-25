using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q09.Test
{
    /// <summary>質數測試</summary>
    [TestFixture]
    public class PrimeTest2
    {
        /// <summary>
        /// 質數共用測試方法
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="primeList">質數的列表</param>
        /// <param name="isPrime">是否是質數</param>
        private void CheckPrimeResult(int number, List<int> primeList, bool isPrime)
        {
            //建立物件
            PrimeAnalysis prime = new PrimeAnalysis();
            //顯示結果
            bool m_isPrime = prime.IsPrime(number, primeList);
            //驗證結果是否正確
            Assert.AreEqual(isPrime, m_isPrime);
        }

        /// <summary>質數測試資料true</summary>
        private static PrimeTest2Data[] _primeTestTrue = new[]
        {
            new PrimeTest2Data(){number=2, primeList = new List<int>(){ 2 }, isPrime = true},
            new PrimeTest2Data(){number=3, primeList = new List<int>(){ 2 }, isPrime = true},
            new PrimeTest2Data(){number=37, primeList = new List<int>(){ 2, 3, 5 }, isPrime = true},
            new PrimeTest2Data(){number=173, primeList = new List<int>(){ 2, 3, 5, 7, 11, 13, 17 }, isPrime = true},
            new PrimeTest2Data(){number=179, primeList = new List<int>(){ 2, 3, 5, 7, 11, 13, 17 }, isPrime = true},
        };

        /// <summary>
        /// 質數的測試
        /// </summary>
        /// <param name="primeData">測試的物件</param>
        [Test]
        public void GetPrime_InputNumber_ReturnPrime([ValueSource("_primeTestTrue")]PrimeTest2Data primeData)
        {
            CheckPrimeResult(primeData.number, primeData.primeList, primeData.isPrime);
        }

        /// <summary>質數測試資料false</summary>
        private static PrimeTest2Data[] _primeTestFalse = new[]
        {
            new PrimeTest2Data(){number=4, primeList = new List<int>() { 2 }, isPrime = false},
            new PrimeTest2Data(){number=16, primeList = new List<int>(){ 2, 3 }, isPrime = false},
            new PrimeTest2Data(){number=52, primeList = new List<int>(){ 2, 3, 5, 7 }, isPrime = false},
            new PrimeTest2Data(){number=99, primeList = new List<int>(){ 2, 3, 5, 7, 11 }, isPrime = false},
            new PrimeTest2Data(){number=100, primeList = new List<int>(){ 2, 3, 5, 7, 11 }, isPrime = false},
            new PrimeTest2Data(){number=888, primeList = new List<int>(){ 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 }, isPrime = false},
        };

        /// <summary>
        /// 非質數的測試
        /// </summary>
        /// <param name="primeData">測試的物件</param>
        [Test]
        public void GetPrime_InputNumber_ReturnNotPrime([ValueSource("_primeTestFalse")]PrimeTest2Data primeData)
        {
            CheckPrimeResult(primeData.number, primeData.primeList, primeData.isPrime);
        }

        /// <summary>質數測試資料false</summary>
        private static PrimeTest2Data[] _primeTestOther = new[]
        {
            new PrimeTest2Data(){number=-1, primeList = new List<int>(), isPrime = false, message = "判斷質數必須為正整數"},
            new PrimeTest2Data(){number=0, primeList = new List<int>(), isPrime = false, message = "判斷質數必須為正整數"},
        };

        /// <summary>
        /// 超出範圍的測試
        /// </summary>
        /// <param name="primeData">測試的物件</param>
        [Test]
        public void GetPrime_InputNumber_ReturnOutOfRange([ValueSource("_primeTestOther")]PrimeTest2Data primeData)
        {
            string m_result = string.Empty;
            try
            {
                CheckPrimeResult(primeData.number, primeData.primeList, true);
            }
            catch (Exception ex)
            {
                m_result = ex.Message;
            }
            //驗證結果是否正確
            Assert.AreEqual(primeData.message, m_result);
        }
    }
}
