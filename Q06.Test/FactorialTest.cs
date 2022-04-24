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
            int m_factorialSum = factorial.GetFactorial(number);
            //驗證結果是否正確
            Assert.AreEqual(factorialSum, m_factorialSum);
        }

        /// <summary>
        /// 階乘和的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="factorialSum">階乘的和</param>
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(5, 120)]
        [TestCase(6, 720)]
        [TestCase(7, 5040)]
        [TestCase(8, 40320)]
        [Test]
        public void GetFactorial_InputNumber_ReturnFactorial(int number, int factorialSum)
        {
            CheckFactorialResult(number, factorialSum);
        }

        /// <summary>
        /// 超出範圍的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="result">顯示結果</param>
        [TestCase(-1, "階乘數字必須為0以上的整數")]
        [Test]
        public void GetFactorial_InputNumber_ReturnOutOfRange(int number, string result)
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
