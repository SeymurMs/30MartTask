using System;
using System.Collections.Generic;
using System.Text;

namespace _29MartPraktice
{
    class Horse:Animal
    {
        public Horse()
        {
            TotalCount++;
            
        }
        public static int TotalCount { get; private set; }
         
        public string Sort { get; set; }
    }
}
