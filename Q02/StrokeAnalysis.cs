using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
{
    /// <summary>行程分析</summary>
    public class StrokeAnalysis
    {
        public (EStroke stroke, EAction action) GetTodayStroke(DateTime nowDate, decimal temperature, EWeather weather)
        {
            EStroke stroke = EStroke.NONE;
            EAction action = EAction.NONE;

            DayOfWeek day = nowDate.DayOfWeek;
            switch(day)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    stroke = EStroke.OUTING;
                    break;
                default:
                    stroke = EStroke.WORKING;
                    break;
            }

            switch(stroke)
            {
                case EStroke.OUTING:
                    if (temperature >= 30)
                    {
                        action = EAction.SWIM;
                    }
                    else
                    {
                        action = EAction.HIKING;
                    }
                    break;
                case EStroke.WORKING:
                    switch(weather)
                    {
                        case EWeather.SUNNY:
                            action = EAction.BUSINESS;
                            break;
                        default:
                            action = EAction.INTERNET;
                            break;
                    }
                    break;
            }
            return (stroke, action);
        }
    }
}
