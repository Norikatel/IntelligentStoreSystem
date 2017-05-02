using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStoreSystem { 
    class Buyer:Worker
    {
        public int Cash { get; set; }
        public Buyer(string firstName, string secondName, Professions profession,int cash):base(firstName,secondName,profession) {
            Cash = cash;
        }
    }
}
