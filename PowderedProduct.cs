using System;
using System.Collections.Generic;
using System.Text;

namespace Activity
{
    class PowderedProduct : Product
    {
        private string _drinkType;
        private string _flavor;
        private string _size;

        public string DrinkType
        {
            get => _drinkType;
            set => _drinkType = value;
        }
        public string Flavor
        {
            get => _flavor;
            set => _flavor = value;
        }
        public string Size
        {
            get => _size;
            set => _size = value;
        }

        public PowderedProduct(string name) : base(name)
        {
            
            Type = "PowderedDrink";

        }
    }
}
