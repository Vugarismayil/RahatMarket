using System;
using System.Collections.Generic;
using System.Text;

namespace HometaskPolymorphism
{
    internal class Dairy : Products
    {
        public double Fatpercent;
        public void ShowDairyInfo()
        {
            Console.WriteLine($"Name: {Name} - Price: {Price} - FatPercent{Fatpercent} - No{No}");
        }

        public static explicit operator Dairy(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
