﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp143
{
  public class NegativeNumberException:Exception
    {
        public NegativeNumberException() : base("Illegal operation for a negative number")
        {
        }
        public NegativeNumberException(string messageValue) : base(messageValue)
        {
        }
        public NegativeNumberException(string messageValue, Exception inner) : base(messageValue, inner)
        {
        }


    }
}
