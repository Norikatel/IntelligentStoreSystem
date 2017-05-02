using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStoreSystem
{
    class DiscountProduct:Product
    {
        public double DiscountProcent { get { return 100-Discount * 100; } }

        private double Discount { get ; } = 1;

        public DiscountProduct(string productName,ProductsType productType, double coast,double discountProcent=0):base(productName,productType, coast) {
            if (discountProcent > 0 && discountProcent < 100)
            {
                Discount = 1.0 - discountProcent / 100.0;
                this.Cost *= Discount;
            }
        }
    }
}
