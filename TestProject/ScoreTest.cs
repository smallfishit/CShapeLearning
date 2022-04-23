using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01.Test
{
    [TestFixture]
    public class ScoreTest
    {
        /// <summary>
        /// 超出範圍的測試
        /// </summary>
        /// <param name="score">分數</param>
        /// <param name="result">結果</param>
        [TestCase(-1, "請輸入0~100的整數")]
        [TestCase(101, "請輸入0~100的整數")]
        [Test]
        public void ShowScoreResult_InputScore_ReturnOutOfRange(int score, string result)
        {
            //練習題物件
            ScoreAnalysis analysis = new ScoreAnalysis();
            //顯示結果
            string sResult = analysis.ShowScoreResult(score);
            //驗證結果是否正確
            Assert.AreEqual(result, sResult);
        }

        /// <summary>
        /// 不及格的測試
        /// </summary>
        /// <param name="score">分數</param>
        /// <param name="result">結果</param>
        [TestCase(0, "下次繼續努力")]
        [TestCase(45, "下次繼續努力")]
        [TestCase(59, "下次繼續努力")]
        [Test]
        public void ShowScoreResult_InputScore_ReturnFail(int score, string result)
        {
            //練習題物件
            ScoreAnalysis analysis = new ScoreAnalysis();
            //顯示結果
            string sResult = analysis.ShowScoreResult(score);
            //驗證結果是否正確
            Assert.AreEqual(result, sResult);
        }

        /// <summary>
        /// 及格的測試
        /// </summary>
        /// <param name="score">分數</param>
        /// <param name="result">結果</param>
        [TestCase(60, "考試及格")]
        [TestCase(77, "考試及格")]
        [TestCase(79, "考試及格")]
        [Test]
        public void ShowScoreResult_InputScore_ReturnOK(int score, string result)
        {
            //練習題物件
            ScoreAnalysis analysis = new ScoreAnalysis();
            //顯示結果
            string sResult = analysis.ShowScoreResult(score);
            //驗證結果是否正確
            Assert.AreEqual(result, sResult);
        }

        /// <summary>
        /// 良好的測試
        /// </summary>
        /// <param name="score">分數</param>
        /// <param name="result">結果</param>
        [TestCase(80, "考試良好")]
        [TestCase(83, "考試良好")]
        [TestCase(89, "考試良好")]
        [Test]
        public void ShowScoreResult_InputScore_ReturnGood(int score, string result)
        {
            //練習題物件
            ScoreAnalysis analysis = new ScoreAnalysis();
            //顯示結果
            string sResult = analysis.ShowScoreResult(score);
            //驗證結果是否正確
            Assert.AreEqual(result, sResult);
        }

        /// <summary>
        /// 優秀的測試
        /// </summary>
        /// <param name="score">分數</param>
        /// <param name="result">結果</param>
        [TestCase(90, "考試優秀")]
        [TestCase(95, "考試優秀")]
        [TestCase(100, "考試優秀")]
        [Test]
        public void ShowScoreResult_InputScore_ReturnExcellent(int score, string result)
        {
            //練習題物件
            ScoreAnalysis analysis = new ScoreAnalysis();
            //顯示結果
            string sResult = analysis.ShowScoreResult(score);
            //驗證結果是否正確
            Assert.AreEqual(result, sResult);
        }
    }
}
