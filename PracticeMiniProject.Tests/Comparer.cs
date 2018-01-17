using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeMiniProject.Tests
{
    public class Comparer
    { 
        //When this class is created, you must pass it a function that accepts two objects and returns a bool
        //once created it returns a new Comparer<T>
        public static Comparer<U> Get<U>(Func<U, U, bool> func)
        {
            return new Comparer<U>(func);
        }
    }

    //When this is created
    public class Comparer<T> : Comparer, IEqualityComparer<T>
    {
        private Func<T, T, bool> comparisonFunction;

        public Comparer(Func<T,T,bool> func)
        {
            comparisonFunction = func;
        }

        public bool Equals(T x, T y)
        {
            return comparisonFunction(x, y);
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }
    }
}
