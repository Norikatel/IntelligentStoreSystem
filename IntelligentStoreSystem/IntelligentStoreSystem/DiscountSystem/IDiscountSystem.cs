using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStoreSystem
{
    interface IDiscountSystem
    {
        List<Product> CanToBuyWithDiscount(List<Product> products);
        void SetDiscount(Product product, double discountProcent);
        void SetDiscount(ProductsType productType, double discountProcent);
    }
}
