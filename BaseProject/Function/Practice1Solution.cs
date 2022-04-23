using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BaseProject.Function
{
    /// <summary>練習題1解題類別</summary>
    public class Practice1Solution
    {
        /// <summary>分數</summary>
        public int Score { get; set; }

        /// <summary>基本建構子</summary>
        public Practice1Solution()
        {
            Score = 0;
        }

        /// <summary>
        /// 加入分數的建構子
        /// </summary>
        /// <param name="score">分數</param>
        public Practice1Solution(int score)
        {
            Score = score;
        }

        /// <summary>
        /// 顯示分數結果
        /// </summary>
        /// <param name="score">分數</param>
        public string ShowScoreResult()
        {
            string result = "";
            if(Score < 0 || Score > 100)
            {
                result = "請輸入0~100的整數";
            }
            else if(Score < 60)
            {
                result = "下次繼續努力";
            }
            else if(Score < 80)
            {
                result = "考試及格";
            }
            else if(Score < 90)
            {
                result = "考試良好";
            }
            else
            {
                result = "考試優秀";
            }
            return result;
        }
    }
}