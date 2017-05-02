using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStoreSystem
{
    class Product
    {
        public string ProductName { get; set; }
        public ProductsType ProductType {get;}
        public double Cost { get; set; }
        public Product(string productName,ProductsType productType,double cost) {
            ProductType = productType;
            Cost = cost;
            ProductName = productName;
        }
    }
}
enum ProductsType {
    Ball,
    Bananas,
    SetOfBricks,
    Oven
}