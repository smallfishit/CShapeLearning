using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingFee.Test
{

    [TestFixture]
    public class FeeTest
    {
        /// <summary>
        /// 確認停車費結果
        /// </summary>
        /// <param name="feeData">停車費測試資料</param>
        private void CheckFeeResult(FeeTestData feeData)
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

        /// <summary>停車費測試資料0</summary>
        private static FeeTestData[] _feeTestZero = new[]
        {
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 0, 0, 50), endTime = new DateTime(2022, 4, 20, 0, 9, 40), hours = 0, minutes = 9, fee = 0},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 0, 5, 50), endTime = new DateTime(2022, 4, 20, 0, 15, 40), hours = 0, minutes = 10, fee = 0}
        };

        [Test]
        public void GetFeeFromDate_InputDateTime_ReturnSumZero([ValueSource("_feeTestZero")]FeeTestData feeData)
        {
            CheckFeeResult(feeData);
        }

        /// <summary>停車費測試資料2</summary>
        private static FeeTestData[] _feeTestTwo = new[]
        {
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 9, 5, 50), endTime = new DateTime(2022, 4, 20, 9, 30, 40), hours = 0, minutes = 25, fee = 2},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 9, 5, 50), endTime = new DateTime(2022, 4, 20, 9, 35, 40), hours = 0, minutes = 30, fee = 2}
        };

        [Test]
        public void GetFeeFromDate_InputDateTime_ReturnSumTwo([ValueSource("_feeTestTwo")]FeeTestData feeData)
        {
            CheckFeeResult(feeData);
        }

        /// <summary>停車費測試資料5</summary>
        private static FeeTestData[] _feeTestFive = new[]
        {
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 9, 30, 50), endTime = new DateTime(2022, 4, 20, 10, 10, 40), hours = 0, minutes = 40, fee = 5},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 9, 25, 50), endTime = new DateTime(2022, 4, 20, 10, 15, 40), hours = 0, minutes = 50, fee = 5},
        };

        [Test]
        public void GetFeeFromDate_InputDateTime_ReturnSumFive([ValueSource("_feeTestFive")]FeeTestData feeData)
        {
            CheckFeeResult(feeData);
        }

        /// <summary>停車費測試資料7</summary>
        private static FeeTestData[] _feeTestSeven = new[]
        {
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 9, 40, 40), hours = 1, minutes = 25, fee = 7},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 10, 50), endTime = new DateTime(2022, 4, 20, 9, 40, 40), hours = 1, minutes = 30, fee = 7},
        };

        [Test]
        public void GetFeeFromDate_InputDateTime_ReturnSumSeven([ValueSource("_feeTestSeven")]FeeTestData feeData)
        {
            CheckFeeResult(feeData);
        }

        /// <summary>停車費測試資料10</summary>
        private static FeeTestData[] _feeTestTen = new[]
        {
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 10, 0, 40), hours = 1, minutes = 45, fee = 10},
        };

        [Test]
        public void GetFeeFromDate_InputDateTime_ReturnSumTen([ValueSource("_feeTestTen")]FeeTestData feeData)
        {
            CheckFeeResult(feeData);
        }

        /// <summary>停車費測試資料12</summary>
        private static FeeTestData[] _feeTestTwelve = new[]
        {
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 10, 35, 40), hours = 2, minutes = 20, fee = 12},
        };

        [Test]
        public void GetFeeFromDate_InputDateTime_ReturnSumTwelve([ValueSource("_feeTestTwelve")]FeeTestData feeData)
        {
            CheckFeeResult(feeData);
        }

        /// <summary>停車費測試資料15</summary>
        private static FeeTestData[] _feeTestFifteen = new[]
        {
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 11, 5, 40), hours = 2, minutes = 50, fee = 15},
        };

        [Test]
        public void GetFeeFromDate_InputDateTime_ReturnSumFifteen([ValueSource("_feeTestFifteen")]FeeTestData feeData)
        {
            CheckFeeResult(feeData);
        }

        /// <summary>停車費測試資料17</summary>
        private static FeeTestData[] _feeTestSeventeen = new[]
        {
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 11, 25, 40), hours = 3, minutes = 10, fee = 17},
        };

        [Test]
        public void GetFeeFromDate_InputDateTime_ReturnSumSeventeen([ValueSource("_feeTestSeventeen")]FeeTestData feeData)
        {
            CheckFeeResult(feeData);
        }

        /// <summary>停車費測試資料20</summary>
        private static FeeTestData[] _feeTestTwenty = new[]
        {
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 11, 50, 40), hours = 3, minutes = 35, fee = 20},
        };

        [Test]
        public void GetFeeFromDate_InputDateTime_ReturnSumTwenty([ValueSource("_feeTestTwenty")]FeeTestData feeData)
        {
            CheckFeeResult(feeData);
        }

        /// <summary>停車費測試資料27</summary>
        private static FeeTestData[] _feeTestTwentySeven = new[]
        {
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 13, 40, 40), hours = 5, minutes = 25, fee = 27},
        };

        [Test]
        public void GetFeeFromDate_InputDateTime_ReturnSumTwentySeven([ValueSource("_feeTestTwentySeven")]FeeTestData feeData)
        {
            CheckFeeResult(feeData);
        }

        /// <summary>停車費測試資料30</summary>
        private static FeeTestData[] _feeTestThirty = new[]
        {
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 14, 10, 40), hours = 5, minutes = 55, fee = 30},
            new FeeTestData(){startTime= new DateTime(2022, 4, 20, 8, 15, 50), endTime = new DateTime(2022, 4, 20, 15, 40, 40), hours = 7, minutes = 25, fee = 30}
        };

        [Test]
        public void GetFeeFromDate_InputDateTime_ReturnSumThirty([ValueSource("_feeTestThirty")]FeeTestData feeData)
        {
            CheckFeeResult(feeData);
        }
    }
}
