using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BaseProject.Function
{
    /// <summary>分數分析</summary>
    public class ScoreAnalysis
    {
        /// <summary>
        /// 顯示分數結果
        /// </summary>
        /// <param name="score">分數</param>
        public string ShowScoreResult(int score)
        {
            string result = "";
            if(score < 0 || score > 100)
            {
                result = "請輸入0~100的整數";
            }
            else if(score < 60)
            {
                result = "下次繼續努力";
            }
            else if(score < 80)
            {
                result = "考試及格";
            }
            else if(score < 90)
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