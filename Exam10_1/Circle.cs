using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam10_1
{
    class Circle : Figure
    {
        public Double Diameter { get; set; }

        public Circle(Double diameter)
        {
            Diameter = diameter;
        }
        /// <summary>
        /// 원의 면적을 반환합니다
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return ((Diameter / 2) * (Diameter / 2)) * 3.141592;
        }
    }
}
