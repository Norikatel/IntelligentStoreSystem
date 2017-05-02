using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStoreSystem
{
    class Worker:Person
    {
        public Professions Profession { get; set; }
        public Worker(string firstName, string secondName, Professions profession): base(firstName,secondName) {
            Profession = profession;
        }
    }
}
enum Professions {
Houswife,
Builder,
Sportsman,
Cook
}