using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02.Test
{
    /// <summary>行程測試</summary>
    [TestFixture]
    public class StrokeTest
    {
        /// <summary>
        /// 行程共用測試方法
        /// </summary>
        /// <param name="strokeData">行程測試物件</param>
        private void CheckScoreResult(StrokeTestData strokeData)
        {
            //練習題物件
            StrokeAnalysis analysis = new StrokeAnalysis();
            //顯示結果
            var result = analysis.GetTodayStroke(strokeData.nowDate, strokeData.temperature, strokeData.weather);
            //驗證結果是否正確
            Assert.AreEqual(strokeData.stroke, result.stroke);
            Assert.AreEqual(strokeData.action, result.action);
        }

        /// <summary>行程測試資料-外出游泳</summary>
        private static StrokeTestData[] _strokeTestOutingSwim = new[]
        {
            new StrokeTestData(){nowDate= new DateTime(2022, 4, 23, 0, 0, 0), temperature = 30, weather = EWeather.SUNNY, stroke = EStroke.OUTING, action = EAction.SWIM},
            new StrokeTestData(){nowDate= new DateTime(2022, 4, 24, 0, 0, 0), temperature = 35, weather = EWeather.RAINY, stroke = EStroke.OUTING, action = EAction.SWIM},
        };

        [Test]
        public void GetTodayStroke_InputDateTimeWeather_ReturnResultOutingSwim([ValueSource("_strokeTestOutingSwim")]StrokeTestData strokeData)
        {
            CheckScoreResult(strokeData);
        }

        /// <summary>行程測試資料-外出爬山</summary>
        private static StrokeTestData[] _strokeTestOutingHiking = new[]
        {
            new StrokeTestData(){nowDate= new DateTime(2022, 4, 17, 0, 0, 0), temperature = 29, weather = EWeather.SUNNY, stroke = EStroke.OUTING, action = EAction.HIKING},
            new StrokeTestData(){nowDate= new DateTime(2022, 4, 16, 0, 0, 0), temperature = 20, weather = EWeather.RAINY, stroke = EStroke.OUTING, action = EAction.HIKING},
        };

        [Test]
        public void GetTodayStroke_InputDateTimeWeather_ReturnResultOutingHiking([ValueSource("_strokeTestOutingHiking")]StrokeTestData strokeData)
        {
            CheckScoreResult(strokeData);
        }

        /// <summary>行程測試資料-工作業務</summary>
        private static StrokeTestData[] _strokeTestWorkingBusiness = new[]
        {
            new StrokeTestData(){nowDate= new DateTime(2022, 4, 15, 0, 0, 0), temperature = 38, weather = EWeather.SUNNY, stroke = EStroke.WORKING, action = EAction.BUSINESS},
            new StrokeTestData(){nowDate= new DateTime(2022, 4, 13, 0, 0, 0), temperature = 20, weather = EWeather.SUNNY, stroke = EStroke.WORKING, action = EAction.BUSINESS},
        };

        [Test]
        public void GetTodayStroke_InputDateTimeWeather_ReturnResultWorkingBusiness([ValueSource("_strokeTestWorkingBusiness")]StrokeTestData strokeData)
        {
            CheckScoreResult(strokeData);
        }

        /// <summary>行程測試資料-工作上網</summary>
        private static StrokeTestData[] _strokeTestWorkingNet = new[]
        {
            new StrokeTestData(){nowDate= new DateTime(2022, 4, 15, 0, 0, 0), temperature = 38, weather = EWeather.RAINY, stroke = EStroke.WORKING, action = EAction.INTERNET},
            new StrokeTestData(){nowDate= new DateTime(2022, 4, 14, 0, 0, 0), temperature = 20, weather = EWeather.RAINY, stroke = EStroke.WORKING, action = EAction.INTERNET},
            new StrokeTestData(){nowDate= new DateTime(2022, 4, 11, 0, 0, 0), temperature = 36, weather = EWeather.CLOUDY, stroke = EStroke.WORKING, action = EAction.INTERNET},
            new StrokeTestData(){nowDate= new DateTime(2022, 4, 13, 0, 0, 0), temperature = 25, weather = EWeather.CLOUDY, stroke = EStroke.WORKING, action = EAction.INTERNET},
        };

        [Test]
        public void GetTodayStroke_InputDateTimeWeather_ReturnResultWorkingNet([ValueSource("_strokeTestWorkingNet")]StrokeTestData strokeData)
        {
            CheckScoreResult(strokeData);
        }
    }
}
