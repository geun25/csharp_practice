using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenTest
{
    class BaseClass { }

    class MyClass<T, U>
        where T : BaseClass
        where U : IComparable
    {

    }

    class Calc<T> where T : struct // class 타입 불가
    {
        public T Add(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;

            T result = da + db;
            return result;
        }

        public T Substract(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;

            T result = da - db;
            return result;
        }

        public T Multiply(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;

            T result = da * db;
            return result;
        }

        public T Divide(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;

            T result = da / db;
            return result;
        }
    }
}
