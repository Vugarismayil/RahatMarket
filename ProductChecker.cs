using System;
using System.Collections.Generic;
using System.Text;

namespace HometaskPolymorphism
{
    internal class ProductChecker : Store
    {
        private Product[] products;

        public ProductChecker(Product[] products)
        {
            this.products = products;
        }

        public Drink[] HasDrinkProducts()
        {
            Drink[] drinks = new Drink[0];

            foreach (var product in products)
            {
                if (product is Drink)
                {
                    Product product1 = product;
                    Drink drink = (Drink)product1;
                    Array.Resize(ref drinks, drinks.Length + 1);
                    drinks[drinks.Length - 1] = drink;
                }
            }
            return drinks;
        }

        public Dairy[] HasDairyProducts()
        {
            Dairy[] dairyProducts = new Dairy[0];
            foreach (var product in products)
            {
                if (product is Dairy)
                {
                    Dairy dairy = (Dairy)product;
                    Array.Resize(ref dairyProducts, dairyProducts.Length + 1);
                    dairyProducts[dairyProducts.Length - 1] = dairy;
                }
            }
            return dairyProducts;
        }

        public void CheckProducts()
        {
            Drink[] drinks = HasDrinkProducts();
            Dairy[] dairyProducts = HasDairyProducts();

            Console.WriteLine("Drink products:");
            foreach (var drink in drinks)
            {
                Console.WriteLine(drink.Name);
            }

            Console.WriteLine("Dairy products:");
            foreach (var dairy in dairyProducts)
            {
                Console.WriteLine(dairy.Name);
            }
        }
    }

    class Product
    {
    }
}
