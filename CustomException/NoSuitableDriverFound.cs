﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_1.CustomException
{
    public class NoSuitableDriverFound:Exception
    {
        public NoSuitableDriverFound(string msg):base(msg)
        {

                
        }
    }
}
