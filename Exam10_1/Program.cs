using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);
            Circle cir = new Circle(10);
            //PrintRectangleArea(rect);
            //PrintCircleArea(cir);
            PrintFigure(rect);
            PrintFigure(cir);
        }

        //static void PrintRectangleArea(Rectangle rect)
        //{
        //    Console.WriteLine($"사각형의 면적은:{rect.Area()}");
        //}

        //static void PrintCircleArea(Circle cir)
        //{
        //    Console.WriteLine($"원의 면적은:{cir.Area()}");
        //}

        static void PrintFigure(IFigurable obj)
        {
            Console.WriteLine($"{obj.GetType().FullName} 면적 : {obj.Area()}") ; 
        }
    }
} 
