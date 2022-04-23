using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
{
    /// <summary>天氣</summary>
    public enum EWeather
    {
        /// <summary>未定義</summary>
        NONE,
        /// <summary>晴天</summary>
        SUNNY,
        /// <summary>雨天</summary>
        RAINY,
        /// <summary>陰天</summary>
        CLOUDY,
    }

    /// <summary>行程</summary>
    public enum EStroke
    {
        /// <summary>未定義</summary>
        NONE,
        /// <summary>工作</summary>
        WORKING,
        /// <summary>外出</summary>
        OUTING,
    }

    /// <summary>行動</summary>
    public enum EAction
    {
        /// <summary>未定義</summary>
        NONE,
        /// <summary>游泳</summary>
        SWIM,
        /// <summary>爬山</summary>
        HIKING,
        /// <summary>談業務</summary>
        BUSINESS,
        /// <summary>上網</summary>
        INTERNET,
    }
}
