using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam10_1
{
    abstract class Figure : IFigurable
    {
        abstract public Double Area();   
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
