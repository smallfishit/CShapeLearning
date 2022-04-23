using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
{
    public class ComboData
    {
        /// <summary>
        /// 下拉選單的Name(表面顯示的)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 下拉選單的Value(後面要抓的)
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// 一般建構子
        /// </summary>
        public ComboData()
        {
            Name = string.Empty;
            Value = string.Empty;
        }
        /// <summary>
        /// Name和Value一樣的建構子
        /// </summary>
        /// <param name="data"></param>
        public ComboData(string data)
        {
            Name = data;
            Value = data;
        }
        /// <summary>
        /// Name和Value不一樣的建構子
        /// </summary>
        /// <param name="_name">前臺顯示的值</param>
        /// <param name="_value">後台要抓的值</param>
        public ComboData(string _value, string _name)
        {
            Name = _name;
            Value = _value;
        }
    }
}
