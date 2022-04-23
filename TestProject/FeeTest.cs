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
        [Test]
        public void GetFeeFromDate_InputDateTime_ReturnSum()
        {
            List<FeeTestData> feeList = new List<FeeTestData>();

            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 0, 0, 50), new DateTime(2022, 4, 20, 0, 9, 40), 0, 9, 0));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 0, 5, 50), new DateTime(2022, 4, 20, 0, 15, 40), 0, 10, 0));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 9, 5, 50), new DateTime(2022, 4, 20, 9, 30, 40), 0, 25, 2));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 9, 5, 50), new DateTime(2022, 4, 20, 9, 35, 40), 0, 30, 2));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 9, 25, 50), new DateTime(2022, 4, 20, 10, 15, 40), 0, 50, 5));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 9, 5, 50), new DateTime(2022, 4, 20, 10, 5, 40), 1, 0, 5));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 8, 15, 50), new DateTime(2022, 4, 20, 9, 40, 40), 1, 25, 7));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 8, 15, 50), new DateTime(2022, 4, 20, 10, 0, 40), 1, 45, 10));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 8, 15, 50), new DateTime(2022, 4, 20, 10, 35, 40), 2, 20, 12));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 8, 15, 50), new DateTime(2022, 4, 20, 11, 5, 40), 2, 50, 15));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 8, 15, 50), new DateTime(2022, 4, 20, 11, 25, 40), 3, 10, 17));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 8, 15, 50), new DateTime(2022, 4, 20, 11, 50, 40), 3, 35, 20));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 8, 15, 50), new DateTime(2022, 4, 20, 13, 40, 40), 5, 25, 27));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 8, 15, 50), new DateTime(2022, 4, 20, 14, 10, 40), 5, 55, 30));
            feeList.Add(new FeeTestData(new DateTime(2022, 4, 20, 8, 15, 50), new DateTime(2022, 4, 20, 15, 40, 40), 7, 25, 30));

            foreach (FeeTestData feeData in feeList)
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
}
