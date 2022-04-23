using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04.Test
{
    /// <summary>最小數測試</summary>
    [TestFixture]
    public class MininumTest
    {
        /// <summary>
        /// 中間數的測試
        /// </summary>
        /// <param name="number1">第1個數</param>
        /// <param name="number2">第2個數</param>
        /// <param name="number3">第3個數</param>
        /// <param name="middle">中間數</param>
        [TestCase(-1, 1, 2, -1)]
        [TestCase(2.55f, 3.47f, 1.23f, 1.23f)]
        [TestCase(7, 2, 3, 2)]
        [TestCase(6.5f, 7.8f, 3f, 3f)]
        [Test]
        public void ShowScoreResult_InputScore_ReturnOutOfRange(float number1, float number2, float number3, float middle)
        {
            //建立物件
            MininumNumber mininum = new MininumNumber();
            //顯示結果
            float m_mininum = mininum.GetMininumNumber(number1, number2, number3);
            //驗證結果是否正確
            Assert.AreEqual(middle, m_mininum);
        }
    }
}
