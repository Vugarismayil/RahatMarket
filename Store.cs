using System;
using System.Collections.Generic;
using System.Text;

namespace HometaskPolymorphism
{
    internal class Store
    {
        public int DairyProductCount;
        public int AlcoholPercentLimit;

        Products[] products = new Products[0];
         
        public void AddProduct(Products product)
        {
            if (DairyProductCount <= 100 && AlcoholPercentLimit <= 40)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
            }
        }
        public Drink[] HasDrinkproducts()
        {
            Drink[] drink = new Drink[0];

            foreach (var drinkp in products)
            {
                if (drinkp is Drink)
                {
                    Drink dr = (Drink)drinkp;
                    Array.Resize(ref drink, drink.Length + 1);
                    drink[drink.Length - 1] = dr;
                }

            }
            return drink;

        }
        public Dairy[] HasDairyProducts()
        {
            Dairy[] dairypr = new Dairy[0];
            foreach (var item in products)
            {
                if (item is Dairy)
                {

                    Dairy dairy = (Dairy)item;
                    Array.Resize(ref dairypr, dairypr.Length + 1);
                    dairypr[dairypr.Length - 1] = dairy;
                }
            }
            return dairypr;
        }
        public Products HasProductByNo(int no)
        {

            for (int i = 0; i < products.Length; i++)
            {

                if (products[i].No == no)
                {

                    return products[i];
                }
            }
            throw new Exception();
        }

    }
}
