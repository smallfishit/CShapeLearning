using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
{
    public class EnumToString
    {
        public static string GetActionString(EAction action)
        {
            string text = string.Empty;
            switch(action)
            {
                case EAction.SWIM:
                    text = "去游泳";
                    break;
                case EAction.HIKING:
                    text = "去爬山";
                    break;
                case EAction.BUSINESS:
                    text = "去客戶單位談業務";
                    break;
                case EAction.INTERNET:
                    text = "在公司上網查資料";
                    break;
            }
            return text;
        }

        public static string GetStrokeString(EStroke stroke)
        {
            string text = string.Empty;
            switch (stroke)
            {
                case EStroke.WORKING:
                    text = "今天工作";
                    break;
                case EStroke.OUTING:
                    text = "今天外出";
                    break;
            }
            return text;
        }
    }
}
