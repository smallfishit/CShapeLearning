using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Function
{
    public class ParkingFeeCalculator
    {
        /// <summary>開始日期</summary>
        private DateTime startTime;
        /// <summary>結束日期</summary>
        private DateTime endTime;

        /// <summary>開始日期</summary>
        public DateTime StartTime
        {
            get { return startTime; }
            set
            {
                if (endTime != DateTime.MinValue && endTime <= value)
                {
                    throw new Exception("開始時間必須在結束時間之前");
                }
                startTime = value;
            }
        }

        /// <summary>結束日期</summary>
        public DateTime EndTime
        {
            get { return endTime; }
            set
            {
                if (startTime != DateTime.MinValue && startTime >= value)
                {
                    throw new Exception("結束時間必須在開始時間之前");
                }
                endTime = value;
            }
        }

        /// <summary>
        /// 基本建構子
        /// </summary>
        public ParkingFeeCalculator()
        {
            StartTime = DateTime.MinValue;
            EndTime = DateTime.MinValue;
        }

        /// <summary>
        /// 帶入日期的建構子
        /// </summary>
        /// <param name="start_time">開始時間</param>
        /// <param name="end_time">結束時間</param>
        public ParkingFeeCalculator(DateTime start_time, DateTime end_time)
        {
            StartTime = start_time;
            EndTime = end_time;
        }

        /// <summary>計算應付停車費及停車總小時數、分鐘數</summary>
        public (int hours, int minutes, int fee) GetFeeFromDate()
        {
            if (endTime.Date > startTime.Date)
            {
                throw new Exception("開始時間跟結束時間必須在同一天");
            }

            int hours = endTime.Hour - startTime.Hour;
            int minutes = endTime.Minute - startTime.Minute;

            if (minutes < 0)
            {
                hours--;
                minutes += 60;
            }
            else if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }

            //半小時單價
            int helfhourFee = 2;

            //每小時單價
            int hourFee = 5;

            //最大價格
            int maxFee = 30;

            //開始計算
            int fee = 0;
            if (hours == 0 && minutes <= 10)
            {
                fee = 0;
            }
            else if (minutes <= 30 && minutes > 0)
            {
                fee = hours * hourFee + helfhourFee;
            }
            else
            {
                int hour = minutes > 0 ? hours + 1 : hours;
                fee = hour * hourFee;
            }
            fee = fee > maxFee ? maxFee : fee;
            return (hours, minutes, fee);
        }
    }
}
