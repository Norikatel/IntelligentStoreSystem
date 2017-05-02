using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStoreSystem { 
    interface IIntelligentSystem
    {
        List<Product> CanToBuy(Buyer buyers, List<Product> products);
    }
}
