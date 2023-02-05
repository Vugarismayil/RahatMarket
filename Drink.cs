using System;
using System.Collections.Generic;
using System.Text;

namespace HometaskPolymorphism
{
    internal class Drink : Products
    {
        public double Alcoholpercent;

        public void ShowDrinkInfo()
        {
            Console.WriteLine($"Name: {Name} - Price: {Price} - AlcoholPercent: {Alcoholpercent} - No{No}");
        }

        internal void HasDrinkproducts()
        {
            throw new NotImplementedException();
        }

        public static explicit operator Drink(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
