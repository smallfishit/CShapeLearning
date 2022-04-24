using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{ 
    public class PalindromeAnalysis
    {
        /// <summary>確認輸入數字是否為迴文</summary>
        /// <param name="number">輸入數字</param>
        /// <returns></returns>
        public bool IsPalindrome(int number)
        {
            if (number < 1)
            {
                throw new Exception("迴文數字必須為正整數");
            }

            //求出位數
            string numText = number.ToString();
            int length = numText.Length;
            int half = (length - 1) / 2;

            for (int i=0;i<=half;i++)
            {
                if(numText[i] != numText[length-i-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
