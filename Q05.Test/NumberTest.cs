using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05.Test
{
    /// <summary>數字測試</summary>
    [TestFixture]
    public class NumberTest
    {
        /// <summary>行程測試資料-外出游泳</summary>
        private static NumberTestData[] _numberTestDevideThreeNotDevideFive = new[]
        {
            new NumberTestData(){number=5, resultList = new List<int>() { 3 }},
            new NumberTestData(){number=10, resultList = new List<int>() { 3, 6, 9 }},
            new NumberTestData(){number=20, resultList = new List<int>() { 3, 6, 9, 12, 18 }},
            new NumberTestData(){number=30, resultList = new List<int>() { 3, 6, 9, 12, 18, 21, 24, 27 }},
            new NumberTestData(){number=33, resultList = new List<int>() { 3, 6, 9, 12, 18, 21, 24, 27, 33 }},
            new NumberTestData(){number=40, resultList = new List<int>() { 3, 6, 9, 12, 18, 21, 24, 27, 33, 36, 39 }},
        };

        [Test]
        public void GetDevideThree_NotDevideFive_InputDateTimeWeather_ReturnResultOutingSwim([ValueSource("_numberTestDevideThreeNotDevideFive")]NumberTestData numberData)
        {
            //建立物件
            NumberAnalysis analysis = new NumberAnalysis();
            //顯示結果
            List<int> resultList = analysis.GetDevideThreeNotDevideFive(numberData.number);
            //驗證結果是否正確
            Assert.AreEqual(numberData.resultList, resultList);
        }
    }
}
