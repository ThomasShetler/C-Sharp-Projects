﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLdatabaseStuff
{
    public class AgeException : Exception
    {
        public AgeException()
        : base() { }
        public AgeException(string message)
            : base(message) { }
        
    }
}
