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

        /// <summary>
        /// 取得所有5位數迴文
        /// </summary>
        public List<int> GetAllFivePalindrome()
        {
            List<int> palindromeList = new List<int>();
            //直接列出所有迴文數
            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        int number = i * 10000 + j * 1000 + k * 100 + j * 10 + i;
                        if(IsPalindrome(number))
                        {
                            palindromeList.Add(number);
                        }
                        else
                        {
                            throw new Exception("迴文的程式邏輯有誤");
                        }
                    }
                }
            }
            return palindromeList;
        }
    }
}
