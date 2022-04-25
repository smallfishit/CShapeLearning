using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03
{
    /// <summary>使用者資料</summary>
    public class UserData : IComparable<UserData>, IComparable
    {
        /// <summary>姓名</summary>
        public string Name { get; set; }
        /// <summary>年齡</summary>
        public int Age { get; set; }

        /// <summary>基本建構子</summary>
        public UserData()
        {
            Name = string.Empty;
            Age = 0;
        }

        /// <summary>
        /// 帶參數的建構子
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="age">年齡</param>
        public UserData(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(UserData data)
        {
            return Age.CompareTo(data.Age);
        }

        public int CompareTo(object obj)
        {
            if (obj is UserData)
            {
                return CompareTo((UserData)obj);
            }
            throw new NotImplementedException();
        }
    }
}
