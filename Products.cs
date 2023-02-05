using System;
using System.Collections.Generic;
using System.Text;

namespace HometaskPolymorphism
{
    internal class Products
    {
        public int No;
        private int _totalcount;
        public string Name;
        public double Price;
        public Products()
        {
            _totalcount++;
            No = _totalcount;
        }
        public void ProductShowInfo()
        {
            Console.WriteLine($"Name: {Name} - Price: {Price} - No{No}");
        }
    }
}
