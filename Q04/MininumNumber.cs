﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04
{
    public class MininumNumber
    {
        public float GetMininumNumber(float number1, float number2, float number3)
        {
            List<float> list = new List<float>();
            list.Add(number1);
            list.Add(number2);
            list.Add(number3);
            list.Sort();
            return list[0];
        }
    }
}
