using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q08.Test
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
        private void CheckNarcissisticResult(int number, bool isNarcissistic)
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
        [TestCase(370, true)]
        [TestCase(371, true)]
        [TestCase(407, true)]
        [Test]
        public void GetNarcissistic_InputNumber_ReturnNarcissistic(int number, bool isNarcissistic)
        {
            CheckNarcissisticResult(number, isNarcissistic);
        }

        /// <summary>
        /// 非水仙花數的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="isNarcissistic">是否是水仙花數</param>
        [TestCase(166, false)]
        [TestCase(500, false)]
        [TestCase(777, false)]
        [TestCase(889, false)]
        [TestCase(987, false)]
        [TestCase(654, false)]
        [Test]
        public void GetNarcissistic_InputNumber_ReturnNotNarcissistic(int number, bool isNarcissistic)
        {
            CheckNarcissisticResult(number, isNarcissistic);
        }

        /// <summary>
        /// 超出範圍的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="result">顯示結果</param>
        [TestCase(-1, "水仙花數必須為0以上的整數")]
        [Test]
        public void GetNarcissistic_InputNumber_ReturnOutOfRange(int number, string result)
        {
            string m_result = "";
            try
            {
                CheckNarcissisticResult(number, true);
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
