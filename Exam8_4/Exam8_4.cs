using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam8_4
{
    class Exam8_4
    {
        public void Run()
        {
            Scholarship scholar = new Scholarship();
            Student st = new Student();
            st.ReadProperty();
            scholar.MyStudent = st;
            scholar.EvalScholarShip();
        }
    }
}
