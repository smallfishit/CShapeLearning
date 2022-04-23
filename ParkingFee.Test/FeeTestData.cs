using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingFee.Test
{
    /// <summary>停車費測試資料</summary>
    public class FeeTestData
    {
        /// <summary>開始時間</summary>
        public DateTime startTime { get; set; }
        /// <summary>結束時間</summary>
        public DateTime endTime { get; set; }
        /// <summary>預期的小時數</summary>
        public int hours { get; set; }
        /// <summary>預期的分鐘數</summary>
        public int minutes { get; set; }
        /// <summary>預期的停車費</summary>
        public int fee { get; set; }


        /// <summary>基本的建構子</summary>
        public FeeTestData()
        {
            startTime = DateTime.MinValue;
            endTime = DateTime.MinValue;
            hours = 0;
            minutes = 0;
            fee = 0;
        }

        /// <summary>
        /// 載入開始結束時間的建構子
        /// </summary>
        /// <param name="startTime">開始時間</param>
        /// <param name="endTime">結束時間</param>
        /// <param name="hours">預期的小時數</param>
        /// <param name="minutes">預期的分鐘數</param>
        /// <param name="fee">預期的停車費</param>
        public FeeTestData(DateTime startTime, DateTime endTime, int hours, int minutes, int fee)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.hours = hours;
            this.minutes = minutes;
            this.fee = fee;
        }
    }
}
