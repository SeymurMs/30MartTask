using System;
using System.Collections.Generic;
using System.Text;

namespace _29MartPraktice
{
    class Farm
    {
        private Animal[] _animals;
        public Farm()
        {
            this._animals = new Animal[0];
        }
        public Animal[] animals { get => _animals; }
        
        public void AddAnimal( Animal animal)
        {
            Array.Resize(ref _animals, _animals.Length + 1);
            _animals[_animals.Length - 1] = animal;
        }
        
    }
}
