using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11.Test
{
    /// <summary>迴文測試</summary>
    [TestFixture]
    public class PalindromeTest
    {
        /// <summary>
        /// 迴文共用測試方法
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="isPalindrome">是否是迴文</param>
        private void CheckPalindromeResult(int number, bool isPalindrome)
        {
            //建立物件
            PalindromeAnalysis Palindrome = new PalindromeAnalysis();
            //顯示結果
            bool m_isPalindrome = Palindrome.IsPalindrome(number);
            //驗證結果是否正確
            Assert.AreEqual(isPalindrome, m_isPalindrome);
        }

        /// <summary>
        /// 迴文的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="isPalindrome">是否是迴文</param>
        [TestCase(12321, true)]
        [TestCase(23432, true)]
        [TestCase(56765, true)]
        [TestCase(73437, true)]
        [TestCase(23932, true)]
        [Test]
        public void GetPalindrome_InputNumber_ReturnPalindrome(int number, bool isPalindrome)
        {
            CheckPalindromeResult(number, isPalindrome);
        }

        /// <summary>
        /// 非迴文的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="isPalindrome">是否是迴文</param>
        [TestCase(43, false)]
        [TestCase(16, false)]
        [TestCase(52, false)]
        [TestCase(786, false)]
        [TestCase(100, false)]
        [TestCase(987, false)]
        [Test]
        public void GetPalindrome_InputNumber_ReturnNotPalindrome(int number, bool isPalindrome)
        {
            CheckPalindromeResult(number, isPalindrome);
        }

        /// <summary>
        /// 超出範圍的測試
        /// </summary>
        /// <param name="number">輸入的數字</param>
        /// <param name="result">顯示結果</param>
        [TestCase(-1, "迴文數字必須為正整數")]
        [TestCase(0, "迴文數字必須為正整數")]
        [Test]
        public void GetPalindrome_InputNumber_ReturnOutOfRange(int number, string result)
        {
            string m_result = "";
            try
            {
                CheckPalindromeResult(number, true);
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
