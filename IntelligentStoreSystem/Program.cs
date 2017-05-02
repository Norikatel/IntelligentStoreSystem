using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStoreSystem
{
    class Program
    {
        public static List<Product> FillProductsList() {
            return (new List<Product>{
                new Product("Ball",ProductsType.Ball, 10),
                new Product("Bananas",ProductsType.Bananas, 20),
                new Product("Set Of Bricks",ProductsType.SetOfBricks, 100),
                new Product("Oven",ProductsType.Oven, 1000) });
        }
        public static List<Buyer> FillBuyerList() {
            return (new List<Buyer> {
                new Buyer("Mary","Parker",Professions.Houswife,100),
                new Buyer("Peter","McDonald",Professions.Builder,500),
                new Buyer("Mike","Stavchinsky",Professions.Sportsman,2000),
                new Buyer("Kate","Bush",Professions.Cook,400)
            });
        }

        static void OutputCanToBuyProducts(List<Buyer> buyers, IntelligentStoreWithDiscount store) {
            foreach (Buyer b in buyers)
            {
                List<Product> canBuyList = store.IntelligentSystem.CanToBuy(b, store.DiscountSystem.CanToBuyWithDiscount(store.ListOfProducts));
                Console.Write(b.FirstName + " can buy ");
                foreach (var p in canBuyList) {
                    DiscountProduct dp = p as DiscountProduct;
                    if(dp!=null)
                        Console.Write(dp.ProductName + " with discount "+ dp.DiscountProcent + "%, ");
                    else
                        Console.Write(p.ProductName + ", ");
                }
                Console.WriteLine();
            }
        }

        static void AddDiscounts(IntelligentStoreWithDiscount store) {
            //Если раньше Mary не могла купить oven, то после скидки - может
            //работает с любой из строчек
            // store.DiscountSystem.SetDiscount(store.ListOfProducts.ElementAt(3),90);
            store.DiscountSystem.SetDiscount(ProductsType.Oven, 90);
        }

        static void Main(string[] args)
        {
            List<Buyer> buyers = FillBuyerList();
            IntelligentStoreWithDiscount store = new IntelligentStoreWithDiscount(FillProductsList(),new IntelligentSystem(),new DiscountSystem());
            AddDiscounts(store);
            OutputCanToBuyProducts(buyers, store);
            Console.ReadKey();
        }
    }
}
