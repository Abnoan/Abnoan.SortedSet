using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.SortedSet.Exemplos
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class AgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}