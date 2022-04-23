using BaseProject.Function;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestFixture]
    public class Q01Test
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="score">分數</param>
        /// <param name="result">結果</param>
        [TestCase(-1, "請輸入0~100的整數")]
        [TestCase(101, "請輸入0~100的整數")]
        [TestCase(45, "下次繼續努力")]
        [TestCase(60, "考試及格")]
        [TestCase(77, "考試及格")]
        [TestCase(80, "考試良好")]
        [TestCase(83, "考試良好")]
        [TestCase(90, "考試優秀")]
        [TestCase(95, "考試優秀")]
        [TestCase(100, "考試優秀")]
        [Test]
        public void ShowScoreResult_InputScore_ReturnResult(int score, string result)
        {
            //練習題物件
            Q01Solution practice = new Q01Solution();
            //顯示結果
            string sResult = practice.ShowScoreResult(score);
            //驗證結果是否正確
            Assert.AreEqual(result, sResult);
        }
    }
}
