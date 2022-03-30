using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_2
{
    class Human
    {
        
        public string Name;
        public string SurName;
        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                
                    if (value > 0)
                    {
                        _age = value;
                        return;
                    }throw new AgeException("Sehvdi Emoglu !!!!!!!!!!!");
               
                
            }
        }
    }
}
