using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().TestCode();
            Console.ReadLine();
        }

        void TestCode()
        {
            var addOp = new DeleCalc(Add);
            Calc(6, 3, addOp);
            Calc(6, 3, Substract);
            Calc(6, 3, Power);

        }

        delegate int DeleCalc(int a, int b);

        void Calc(int a, int b, DeleCalc calc)
        {
            //int res = 0;
            //switch(flag)
            //{
            //    case "Add":
            //        res = Add(a, b);
            //        break;
            //    case "Substract":
            //        res = Substract(a, b);
            //        break;
            //    //case...
            //    default:
            //        break;
            //}

            int res = calc(a, b);
            Console.WriteLine($"사용함수 : {calc.Method}");
            Console.WriteLine($"f({a},{b}) = {res}");
        }

        #region delegate 타입에 맞는 메서드들
        int Add(int a, int b)
        {
            return a + b;
        }

        int Substract(int a, int b)
        {
            return a - b;
        }

        int Multiply(int a, int b)
        {
            return a * b;
        }


        int Divide(int a, int b)
        {
            return a / b;
        }

        int Mod(int a, int b)
        {
            return a % b;
        }

        int Power(int a, int b)
        {
            int r = 1;
            for(int i = 0; i < b; i++)
            {
                r *= a;
            }
            return r;
        }
        #endregion
    }
}
