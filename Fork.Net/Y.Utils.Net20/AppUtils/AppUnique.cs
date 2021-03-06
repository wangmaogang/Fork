﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Y.Utils.Net20.AppUtils
{
    public sealed class AppUnique
    {
        /// <summary>
        /// 判断应用在当前系统实例下是否唯一
        /// </summary>
        /// <param name="appName"></param>
        /// <returns></returns>
        public static bool IsUnique(string appName)
        {
            bool unique;
            Mutex run = new Mutex(true, appName, out unique);
            return unique;
        }
    }
}
