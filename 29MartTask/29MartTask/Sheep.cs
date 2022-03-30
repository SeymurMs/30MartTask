using System;
using System.Collections.Generic;
using System.Text;

namespace _29MartPraktice
{
    class Sheep: Animal
    {
        public Sheep()
        {
            TotalCount++;
            
        }
        public static int TotalCount { get; private set; }
        public string Type { get; set; }
    }
}
