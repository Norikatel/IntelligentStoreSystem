using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStoreSystem
{
    class IntelligentStoreWithDiscount:IntelligentStore
    {
        public IDiscountSystem DiscountSystem { get; }
        public IntelligentStoreWithDiscount(List<Product> listOfProducts, IIntelligentSystem intelligentSystem, IDiscountSystem discountedSystem) :base(listOfProducts,intelligentSystem){
            DiscountSystem = discountedSystem;
        }
    }
}
