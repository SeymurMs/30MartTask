﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_2
{
    class AgeException:Exception
    {
        public AgeException(string message) : base(message)
        {
        }
    }
}
