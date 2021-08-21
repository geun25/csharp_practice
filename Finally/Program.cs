using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally
{
    class Program
    {
        static int Divide(int dividend, int divisor)
        {
            try
            {
                Console.WriteLine("Divide() 시작");
                return dividend / divisor;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide() 예외 발생");
                throw e;
            }
            finally
            {
                Console.WriteLine("Divide() 끝");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("제수 입력 : ");
                string temp = Console.ReadLine();
                int dividend = int.Parse(temp);

                Console.WriteLine("피제수 입력 : " );
                temp = Console.ReadLine();
                int divisor = int.Parse(temp);

                Console.WriteLine("{0}/{1} = {2}", dividend, divisor, Divide(dividend, divisor));
            }
            catch (FormatException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램을 종료");
            }
        }
    }
}
