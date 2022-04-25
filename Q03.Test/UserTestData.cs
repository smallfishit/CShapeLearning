using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03.Test
{
    /// <summary>使用者測試資料</summary>
    public class UserTestData
    {
        /// <summary>使用者列表</summary>
        public List<UserData> userList { get; set; }
        /// <summary>預期的中間數</summary>
        public int age { get; set; }


        /// <summary>基本的建構子</summary>
        public UserTestData()
        {
            userList = new List<UserData>();
            age = 0;
        }

        /// <summary>
        /// 載入開始結束時間的建構子
        /// </summary>
        /// <param name="userList">使用者列表</param>
        /// <param name="age">預期的中間數</param>
        public UserTestData(List<UserData> userList, int age)
        {
            this.userList = userList;
            this.age = age;
        }
    }
}
