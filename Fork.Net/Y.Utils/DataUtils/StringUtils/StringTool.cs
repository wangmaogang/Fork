﻿//############################################################
//      https://github.com/yuzhengyang
//      author:yuzhengyang
//############################################################
using System;
using System.Collections.Generic;
using System.Text;

namespace Y.Utils.DataUtils.StringUtils
{
    public class StringTool
    {
        public static bool IsNullOrWhiteSpace(string str)
        {
            if (str == null)
                return true;
            if (str.Trim().Length == 0)
                return true;

            return false;
        }
    }
}
