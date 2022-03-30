using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_3
{
    internal class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {

        }
    }
}
