using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStoreSystem
{
    class Store
    {
        public List<Product> ListOfProducts { get; set; }
        public Store(List<Product> listOfProducts) {
            ListOfProducts = listOfProducts;
        }
    }
}
