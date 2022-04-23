using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02.Test
{
    /// <summary>行程測試資料</summary>
    public class StrokeTestData
    {
        /// <summary>今天日期</summary>
        public DateTime nowDate { get; set; }
        /// <summary>氣溫</summary>
        public decimal temperature { get; set; }
        /// <summary>天氣</summary>
        public EWeather weather { get; set; }
        /// <summary>預期的行程</summary>
        public EStroke stroke { get; set; }
        /// <summary>預期的行動</summary>
        public EAction action { get; set; }


        /// <summary>基本的建構子</summary>
        public StrokeTestData()
        {
            nowDate = DateTime.MinValue;
            temperature = 0;
            weather = EWeather.NONE;
            stroke = EStroke.NONE;
            action = EAction.NONE;
        }

        /// <summary>
        /// 載入資料的建構子
        /// </summary>
        /// <param name="nowDate">今天日期</param>
        /// <param name="temperature">氣溫</param>
        /// <param name="weather">天氣</param>
        /// <param name="stroke">預期的行程</param>
        /// <param name="action">預期的行動</param>
        public StrokeTestData(DateTime nowDate, decimal temperature, EWeather weather, EStroke stroke, EAction action)
        {
            this.nowDate = nowDate;
            this.temperature = temperature;
            this.weather = weather;
            this.stroke = stroke;
            this.action = action;
        }
    }
}
