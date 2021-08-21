using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam11_1
{
    class StudentClass : IEnumerable
    {
        object[] classArray = new object[];
        public IEnumerator GetEnumerator()
        {
           
        }

        class StudentEnumerator : IEnumerator
        {
            public object Current => throw new NotImplementedException();

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
