using BaseProject.Function;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models;

namespace TestProject
{

    [TestFixture]
    public class FeeTest
    {
        /// <summary>停車費測試資料</summary>
        private static FeeTestData[] _feeTestData = new[]
        {
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 0, 0, 50), endTime = new DateTime(2022, 4, 20, 0, 9, 40), hours = 0, minutes = 9, fee = 0},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 0, 5, 50), endTime = new DateTime(2022, 4, 20, 0, 15, 40), hours = 0, minutes = 10, fee = 0},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 9, 5, 50), endTime = new DateTime(2022, 4, 20, 9, 30, 40), hours = 0, minutes = 25, fee = 2},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 9, 5, 50), endTime = new DateTime(2022, 4, 20, 9, 35, 40), hours = 0, minutes = 30, fee = 2},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 9, 25, 50), endTime = new DateTime(2022, 4, 20, 10, 15, 40), hours = 0, minutes = 50, fee = 5},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 9, 40, 40), hours = 1, minutes = 25, fee = 7},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 10, 0, 40), hours = 1, minutes = 45, fee = 10},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 10, 35, 40), hours = 2, minutes = 20, fee = 12},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 11, 5, 40), hours = 2, minutes = 50, fee = 15},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 11, 25, 40), hours = 3, minutes = 10, fee = 17},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 11, 50, 40), hours = 3, minutes = 35, fee = 20},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 13, 40, 40), hours = 5, minutes = 25, fee = 27},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 14, 10, 40), hours = 5, minutes = 55, fee = 30},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 15, 40, 40), hours = 7, minutes = 25, fee = 30}
        };

        [Test]
        public void GetFeeFromDate_InputDateTime_ReturnSum([ValueSource("_feeTestData")]FeeTestData feeData)
        {
            //建立停車費計算物件
            ParkingFeeCalculator parkFee = new ParkingFeeCalculator(feeData.startTime, feeData.endTime);
            //計算停車費
            var result = parkFee.GetFeeFromDate();
            //驗證結果是否正確
            Assert.AreEqual(feeData.hours, result.hours);
            Assert.AreEqual(feeData.minutes, result.minutes);
            Assert.AreEqual(feeData.fee, result.fee);
        }
    }
}
