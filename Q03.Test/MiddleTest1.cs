using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03.Test
{
    /// <summary>中間數測試</summary>
    [TestFixture]
    public class MiddleTest1
    {
        /// <summary>
        /// 中間數的測試
        /// </summary>
        /// <param name="number1">第1個數</param>
        /// <param name="number2">第2個數</param>
        /// <param name="number3">第3個數</param>
        /// <param name="middle">中間數</param>
        [TestCase(-1, 1, 2, 1)]
        [TestCase(2.55f, 3.47f, 1.23f, 2.55f)]
        [TestCase(7, 2, 3, 3)]
        [TestCase(6.5f, 7.8f, 3f, 6.5f)]
        [Test]
        public void GetMiddleNumber_InputNumbers_ReturnMiddleNumber(float number1, float number2, float number3, float middle)
        {
            //建立物件
            MiddleNumber number = new MiddleNumber();
            //顯示結果
            float m_middle = number.GetMiddleNumber1(number1, number2, number3);
            //驗證結果是否正確
            Assert.AreEqual(middle, m_middle);
        }
    }
}
