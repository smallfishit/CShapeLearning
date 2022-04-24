using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q09.Test
{
    /// <summary>水仙花數測試</summary>
    [TestFixture]
    public class NarcissisticTest
    {
        /// <summary>
        /// 水仙花數共用測試方法
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="isNarcissistic">是否是水仙花數</param>
        private void CheckFactorialResult(int number, bool isNarcissistic)
        {
            //建立物件
            NarcissisticAnalysis narcissistic = new NarcissisticAnalysis();
            //顯示結果
            bool m_isNarcissistic = narcissistic.IsNarcissistic(number);
            //驗證結果是否正確
            Assert.AreEqual(isNarcissistic, m_isNarcissistic);
        }

        /// <summary>
        /// 水仙花數的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="isNarcissistic">是否是水仙花數</param>
        [TestCase(1, true)]
        [TestCase(153, true)]
        [TestCase(166, false)]
        [TestCase(370, true)]
        [TestCase(371, true)]
        [TestCase(407, true)]
        [TestCase(500, false)]
        [Test]
        public void GetFactorial_InputNumber_ReturnFactorial(int number, bool isNarcissistic)
        {
            CheckFactorialResult(number, isNarcissistic);
        }

        /// <summary>
        /// 超出範圍的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="result">顯示結果</param>
        [TestCase(-1, "水仙花數必須為0以上的整數")]
        [Test]
        public void GetFactorial_InputNumber_ReturnOutOfRange(int number, string result)
        {
            string m_result = "";
            try
            {
                CheckFactorialResult(number, true);
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
