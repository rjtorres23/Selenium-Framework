﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Utility
{
    public class ActionExpection : Exception
    {
        public ActionExpection(string message) : base(message)
        {

        }
    }
}
