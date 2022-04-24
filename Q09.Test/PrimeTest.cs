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
    public class PrimeTest
    {
        /// <summary>
        /// 質數共用測試方法
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="isPrime">是否是質數</param>
        private void CheckPrimeResult(int number, bool isPrime)
        {
            //建立物件
            PrimeAnalysis prime = new PrimeAnalysis();
            //顯示結果
            bool m_isPrime = prime.IsPrime(number);
            //驗證結果是否正確
            Assert.AreEqual(isPrime, m_isPrime);
        }

        /// <summary>
        /// 質數的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="isPrime">是否是質數</param>
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(37, true)]
        [TestCase(173, true)]
        [TestCase(179, true)]
        [Test]
        public void GetPrime_InputNumber_ReturnPrime(int number, bool isPrime)
        {
            CheckPrimeResult(number, isPrime);
        }

        /// <summary>
        /// 非質數的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="isPrime">是否是質數</param>
        [TestCase(4, false)]
        [TestCase(16, false)]
        [TestCase(52, false)]
        [TestCase(99, false)]
        [TestCase(100, false)]
        [TestCase(888, false)]
        [Test]
        public void GetPrime_InputNumber_ReturnNotPrime(int number, bool isPrime)
        {
            CheckPrimeResult(number, isPrime);
        }

        /// <summary>
        /// 超出範圍的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="result">顯示結果</param>
        [TestCase(-1, "判斷質數必須為正整數")]
        [TestCase(0, "判斷質數必須為正整數")]
        [Test]
        public void GetPrime_InputNumber_ReturnOutOfRange(int number, string result)
        {
            string m_result = "";
            try
            {
                CheckPrimeResult(number, true);
            }
            catch (Exception ex)
            {
                m_result = ex.Message;
            }
            //驗證結果是否正確
            Assert.AreEqual(result, m_result);
        }
    }
}
