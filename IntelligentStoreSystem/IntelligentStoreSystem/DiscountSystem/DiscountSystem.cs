using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStoreSystem
{
    class DiscountSystem : IDiscountSystem
    {
        private Dictionary<Product, double> listOfProductsDiscount = new Dictionary<Product, double>();
        private Dictionary<ProductsType, double> listOfTypeProductsDiscount = new Dictionary<ProductsType, double>();

        public void SetDiscount(Product product, double discountProcent)
        {
            if (discountProcent > 0 && discountProcent < 100)
                listOfProductsDiscount.Add(product, discountProcent);
        }

        public void SetDiscount(ProductsType productType, double discountProcent)
        {
            if (discountProcent > 0 && discountProcent < 100)
                listOfTypeProductsDiscount.Add(productType, discountProcent);
        }

        public List<Product> CanToBuyWithDiscount(List<Product> products)
        {
            List<Product> discountProductList = new List<Product>();
            foreach (Product p in products)
            {
                double DiscountProcentProduct = 0;
                double DiscountProcentType = 0;
                if (!listOfProductsDiscount.TryGetValue(p, out DiscountProcentProduct) && !listOfTypeProductsDiscount.TryGetValue(p.ProductType, out DiscountProcentType))
                    discountProductList.Add(new Product(p.ProductName, p.ProductType, p.Cost));
                else
                if (DiscountProcentProduct > DiscountProcentType)
                    discountProductList.Add(new DiscountProduct(p.ProductName, p.ProductType, p.Cost, DiscountProcentProduct));
                else
                    discountProductList.Add(new DiscountProduct(p.ProductName, p.ProductType, p.Cost, DiscountProcentType));
            }
            return discountProductList;
        }

    }
}
