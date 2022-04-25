using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03.Test
{

    [TestFixture]
    public class MiddleTest
    {
        /// <summary>使用者測試資料</summary>
        private static UserTestData[] _userTestArray = new[]
        {
            new UserTestData(){ userList = new List<UserData>(){ new UserData("小明", 3), new UserData("小華", 2), new UserData("小英", 5) }, age = 3},
            new UserTestData(){ userList = new List<UserData>(){ new UserData("小明", 3), new UserData("小華", 1), new UserData("小英", 2) }, age = 2},
            new UserTestData(){ userList = new List<UserData>(){ new UserData("小明", 7), new UserData("小華", 2), new UserData("小英", 3) }, age = 3},
            new UserTestData(){ userList = new List<UserData>(){ new UserData("小明", 6), new UserData("小華", 8), new UserData("小英", 3) }, age = 6},
        };

        [Test]
        public void GetMiddleNumber_InputUserList_ReturnMiddle([ValueSource("_userTestArray")]UserTestData testData)
        {
            //建立中間數計算物件
            MiddleNumber middle = new MiddleNumber();
            //計算中間數
            UserData result = middle.GetMiddleNumber<UserData>(testData.userList[0], testData.userList[1], testData.userList[2]);
            //驗證結果是否正確
            Assert.AreEqual(testData.age, result.Age);
        }

    }
}
