using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q06.Test
{
    /// <summary>階乘測試</summary>
    [TestFixture]
    public class FactorialTest
    {
        /// <summary>
        /// 階乘共用測試方法
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="factorialSum">階乘的和</param>
        private void CheckFactorialResult(int number, int factorialSum)
        {
            //建立物件
            FactorialAnalysis factorial = new FactorialAnalysis();
            //顯示結果
            int m_factorialSum = factorial.GetFactorialSum(number);
            //驗證結果是否正確
            Assert.AreEqual(factorialSum, m_factorialSum);
        }

        /// <summary>
        /// 階乘和的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="factorialSum">階乘的和</param>
        [TestCase(1, 1)]
        [TestCase(2, 3)]
        [TestCase(5, 153)]
        [TestCase(6, 873)]
        [TestCase(7, 5913)]
        [Test]
        public void GetFactorialSum_InputNumber_ReturnFactorialSum(int number, int factorialSum)
        {
            CheckFactorialResult(number, factorialSum);
        }

        /// <summary>
        /// 超出範圍的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="result">顯示結果</param>
        [TestCase(-1, "只接受1~10之間的正整數")]
        [TestCase(0, "只接受1~10之間的正整數")]
        [TestCase(11, "只接受1~10之間的正整數")]
        [Test]
        public void GetFactorialSum_InputNumber_ReturnOutOfRange(int number, string result)
        {
            string m_result = "";
            try
            {
                CheckFactorialResult(number, 0);
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
