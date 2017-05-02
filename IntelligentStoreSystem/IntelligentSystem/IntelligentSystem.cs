using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStoreSystem
{
    class IntelligentSystem:IIntelligentSystem
    {
        private Dictionary<Professions, List<ProductsType>> dictionary = new Dictionary<Professions, List<ProductsType>>();
        private void FillOfDictionary(Dictionary<Professions, List<ProductsType>> dictionary) {
            dictionary.Add(Professions.Builder,new List<ProductsType> {ProductsType.SetOfBricks,ProductsType.Bananas });
            dictionary.Add(Professions.Houswife, new List<ProductsType> {ProductsType.Bananas, ProductsType.Oven });
            dictionary.Add(Professions.Sportsman, new List<ProductsType> { ProductsType.Ball, ProductsType.Bananas });
            dictionary.Add(Professions.Cook, new List<ProductsType> { ProductsType.Oven, ProductsType.Bananas });
        }

        public IntelligentSystem() {
            FillOfDictionary(dictionary);
        }

        
        public List<Product> CanToBuy(Buyer buyers, List<Product> products) {
            List<ProductsType> productsType = new List<ProductsType>();
            List<Product> CanToBuyList = new List<Product>();
            if (dictionary.TryGetValue(buyers.Profession, out productsType))
                foreach (Product p in products)
                    if (productsType.Contains(p.ProductType) && p.Cost <= buyers.Cash)
                        CanToBuyList.Add(p);
            return CanToBuyList;
        }
    }
}

