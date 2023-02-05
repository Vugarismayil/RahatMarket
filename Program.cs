using Microsoft.VisualBasic.FileIO;
using System;

namespace HometaskPolymorphism
{
    internal class Program
    {
        public static Product[] products { get; private set; }
        public static Drink drink { get; private set; }

        static void Main(string[] args)
        {
            Store store = new Store();



            ProductChecker productChecker = new ProductChecker(products);

            string opt;
            do
            {
                Console.WriteLine("-------------- Rahat Market --------------");
                Console.WriteLine("----- Mehsullarin Axtaris Sistemi -----");
                Console.WriteLine("1. Drink Mehsul elave et");
                Console.WriteLine("2. Dairy product elave et");
                Console.WriteLine("3. butun mehsullara bax");
                Console.WriteLine("4. Verilmis no ile mehsula bax");
                Console.WriteLine("5. Drink productlarina bax");
                Console.WriteLine("6. Dairy productlarina bax");
                Console.WriteLine("7 Ada gore axtaris sistemi \n Muveqqeti olaraq islemir");
                Console.WriteLine("            8. Qiymet araligina gore axtaris \n ---------- Muveqqeti olaraq islemir ----------");
                Console.WriteLine("            9. Siyahindan mehsul sil \n ---------- Muveqqeti olaraq islemir ---------- ");
                Console.WriteLine("0. Menudan Cix");
                Console.Write("Secim edin:");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("Drink adini daxil edin");
                        string name = Console.ReadLine();
                        Console.WriteLine("Drink qiymetini daxil edin:");
                        string prices = Console.ReadLine();
                        double price = double.Parse(prices);
                        Console.WriteLine("Drink faizini daxil edin:");
                        string alcoholpercent = Console.ReadLine();
                        double alcolper = double.Parse(alcoholpercent);
                        Drink drinks = new Drink
                        {
                            Name = name,
                            Price = price,
                            Alcoholpercent = alcolper
                        };
                        store.AddProduct(drinks);
                        break;
                        Product[] products = new Product[0];
                    case "2":
                        Console.WriteLine("Dairy adini daxil edin");
                        string namestr = Console.ReadLine();
                        Console.WriteLine("Dairy qiymetini daxil edin:");
                        string priceStr = Console.ReadLine();
                        double price1 = double.Parse(priceStr);
                        Console.WriteLine("Dairy yagliliq faizini daxil edin:");
                        string fatpercent1= Console.ReadLine();
                        double fatpercent = double.Parse(fatpercent1);
                        Dairy dairy = new Dairy
                        {
                            Name = namestr,
                            Price = price1,
                            Fatpercent = fatpercent
                        };
                        store.AddProduct(dairy);
                        break;
                    case "3":
                        Drink[] drink = productChecker.HasDrinkProducts();
                        Console.WriteLine("Drink products:");
                        for (int i = 0; i < drink.Length; i++)
                        {
                            Drink dr = NewMethod(i);
                            Console.WriteLine(dr.Name);
                        }
                        Dairy[] dairyProducts = productChecker.HasDairyProducts();
                        Console.WriteLine("Dairy products:");
                        foreach (var dr in dairyProducts)
                        {
                            Console.WriteLine(dr.Name);
                        }
                        break;
                    case "4":
                        Console.WriteLine("No: ");
                        string noStr = Console.ReadLine();
                        int no = Convert.ToInt32(noStr);

                        try
                        {
                            var wantedProduct = store.HasProductByNo(no);
                            wantedProduct.ProductShowInfo();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"{no} nomreli mehsul yoxdur!");
                        }
                        break;
                        case"5":
                        Console.WriteLine(store.HasDrinkproducts());

                        break;
                    case "6":
                        Console.WriteLine(store.HasDairyProducts());
                        break;
                }
            } while (opt!= "0");
        }

        private static Drink NewMethod(int i)
        {
            return drink;
        }
    }
}
