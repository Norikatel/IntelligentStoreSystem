using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentStoreSystem
{
    class Person
    {
        private int Count { get; }
        int PersonID { get; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public Person(string firstName, string secondName)
        {
            FirstName = firstName;
            SecondName = secondName;
            Count++;
            PersonID = Count;
        }
    }
}
