﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDemo
{
    public static class Helper
    {
        public static string ConValue(string name)
        {
            var output = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            return output;
        }
    }
}
		
