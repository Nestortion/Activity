using System;
using System.Collections.Generic;
using System.Text;

namespace Activity
{
    class ClothingProduct : Product
    {
        
        private string _brand;
        private string _size;
        private string _style;

        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }
        public string Size
        {
            get => _size;
            set => _size = value;
        }
        public string Style
        {
            get => _style;
            set => _style = value;
        }

        public ClothingProduct(string name) : base(name)
        {
            
            Type = "Clothing";

        }

    }
}
