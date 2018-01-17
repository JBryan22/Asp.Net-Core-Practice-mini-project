using PracticeMiniProject.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PracticeMiniProject.Tests
{
    class ProductTestData : IEnumerable<object[]>
    {
        private Book[] GetPricesUnder15 => new Book[] 
        {
            new Book { ID = 1, Title = "Lala", Author = "JBear", Price = 13M },
            new Book { ID = 2, Title = "Whatever", Author = "JBear", Price = 10M },
            new Book { ID = 3, Title = "Stuff", Author = "JBear", Price = 2M }
        };

        private Book[] GetPricesOver15 => new Book[]
        {
            new Book { ID = 1, Title = "hmm", Author = "Jball", Price = 23M },
            new Book { ID = 2, Title = "ok", Author = "Jball", Price = 20M },
            new Book { ID = 3, Title = "pricey", Author = "Jball", Price = 25M }
        };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { GetPricesUnder15 };
            yield return new object[] { GetPricesOver15 };
        }
    }
}
