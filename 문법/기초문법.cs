using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            
            string str1 = "kim";
            string str2 = "dogeun";
            string str3 = str1 + str2;
            Console.WriteLine("{0}", str3);
            Console.WriteLine(str2[1]);

            Console.WriteLine("문자 개수 : {0}", str2.Length);

            var value = 3.141592f;
            Console.WriteLine("{0:f3}", value);
            value.ToString();
            Console.WriteLine(value);

            ConsoleKeyInfo KeyInfo;
            do
            {
                KeyInfo = Console.ReadKey(true); // 화면 출력 X
                if (KeyInfo.KeyChar == 'a')
                    Console.WriteLine("a가 눌렷다");
                //Console.Write(KeyInfo.KeyChar);
            } while (KeyInfo.Key != ConsoleKey.Escape);

            int a, b, c, t;
            float Avg;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            t = a + b + c;
            Avg = t / 3.0f;
            Console.WriteLine("{0} {1} {2} {3} {4:f1}", a, b, c, t, Avg);   
        }
    }
    */

    /*
    public struct MyStruct
    {
        public const float PI = 3.14f;
        public static int Age = 12;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", MyStruct.PI, MyStruct.Age);
        }
    }
    */

    /*
    public struct MyStruct
    {
        public int Age; // const, static제외 초기화 불가
        public MyStruct(int InAge)
        {
            Age = InAge;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct TestStruct1;
            TestStruct1.Age = 12;
            Console.WriteLine(TestStruct1.Age);

            MyStruct TestStruct2 = new MyStruct();
            Console.WriteLine(TestStruct2.Age); // 0이 출력된다.

            MyStruct TestStruct3 = new MyStruct(12);
            Console.WriteLine("{0}", TestStruct3.Age);
        }
    }
    */

    /*
    public struct MyStruct
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct TestStruct1, TestStruct2;
            
            MyStruct test = new MyStruct(); 
            Console.WriteLine(test.Age); //기본 생성자에 의해 0으로 자동 초기화

            TestStruct2.Age = 10;
            TestStruct1 = TestStruct2;
            Console.WriteLine("{0}", TestStruct1.Age);
        }
    }
    */

    /*
    public struct MyStruct
    {
        public int Age;
    }

    class MyClass
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 값 복사가 이루어지는 구조체
            MyStruct test1 = new MyStruct(); 
            test1.Age = 12;
            MyStruct test2 = test1;
            test2.Age = 24;
            Console.WriteLine("{0} {1}", test1.Age, test2.Age);

            // 같은 객체를 참조하는 클래스
            MyClass test3 = new MyClass();
            test3.Age = 12;
            MyClass test4 = test3;
            test4.Age = 24;
            Console.WriteLine("{0} {1}", test3.Age, test4.Age);
        }
    }
    */

    /*
    public struct MyStruct
    {
        public int K, E, M, T;
        public float Avg;
        public void Compute()
        {
            T = K + E + M;
            Avg= T / 3.0f;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct test = new MyStruct();
            test.K = 95;
            test.E = 84;
            test.M = 90;
            test.Compute();
            Console.WriteLine("총점 : {0} 평균 : {1:f1}", test.T, test.Avg);
        }
    }
    */

    /*
    enum Days { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat };
    
    class Program
    {
        static void Main(string[] args)
        {
            int nValue = (int)Days.Mon;
            Days day = Days.Tue;
            Console.WriteLine("{0} {1}", nValue, day);
        }
    }
    */

    /*
    class Program
    {
        static void Main(string[] args)
        {
            int nVal1 = 12;
            int nVal2 = new int(); //값 형식임에도 불구하고 생성가능
            Console.WriteLine("{0} {1}", nVal1, nVal2);
        }
    }
    */

    /*
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 2, 3 };
            int[] RefArray; // 참조형 배열 변수
            RefArray = Array1; // 대입연산자를 통한 별명 설정
            RefArray[1] = 20;
            Console.WriteLine("{0} {1} {2}", Array1[0], Array1[1], Array1[2]);
        }
    }
    */

    /*
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = 1 + "test" + 3.14f + "abcd";
            Console.WriteLine(str);
        }
    }
    */

    /*
    class A
    {
    }

    class B
    { 
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123";
            object obj = str1;
            string str2 = obj as string;
            Console.WriteLine(str2);

            A test1 = new A();
            object obj1 = test1;
            B test2 = obj1 as B; // null 저장
            if (test2 == null)
                Console.WriteLine("형변환 실패");
            else
                Console.WriteLine("형변환 성공");
        }
    }
    */

    /*
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null; // nullable 형식, null 저장 가능
            int y = x ?? -1;
            Console.WriteLine(y);
            x = 10;
            y = x ?? -1;
            Console.WriteLine(y);
        }
    }
    */

    /*
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3};
            try
            {
                Array[3] = 10;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("배열 인덱스 에러 발생");
                Console.WriteLine(e.ToString());
                Array[2] = 10;
            }

            for(int i = 0; i < Array.Length; i++)
            {
                Console.Write("{0}", Array[i]);
            }
        }
    }
    */

    /*
    class Program
    {
        static int GetNumber(int index)
        {
            int[] nums = { 300, 600, 900 };
            if(index >= nums.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return nums[index];
        }

        static void Main(string[] args)
        {
            int result = GetNumber(3);
        }
    }
    */

    /*
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nArray1 = new int[2, 2];
            nArray1[0, 0] = 1;
            nArray1[0, 1] = 2;
            nArray1[1, 0] = 3;
            nArray1[1, 1] = 4;

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.Write(nArray1[i, j] + " ");
            Console.Write('\n');

            int[,] nArray2 = { { 1, 2 }, { 3, 4 } };

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.Write(nArray2[i, j] + " ");
            Console.Write('\n');

            string[,,] strArray = { { { "ab", "cd" }, { "ef", "gh" } }, { { "ij", "kl" }, { "mn", "op" } } };

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 2; k++)
                        Console.Write(strArray[i, j, k] + " ");
        }
    }
    */

    /*
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[2][];
            array[0] = new int[3] { 1, 2, 3 };
            array[1] = new int[2] { 4, 5 };

            for(int i=0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write(array[i][j]);
            }
        }
    }
    */

    /*
    class Program
    {
        static void Main(string[] args)
        {
            int[][][] array3 = new int[2][][]; // 면 생성  
            array3[0] = new int[2][];
            array3[1] = new int[3][];

            //2행
            array3[0][0] = new int[3] { 1, 2, 3 };
            array3[0][1] = new int[2] { 4, 5 };

            //3행
            array3[1][0] = new int[3] { 6, 7, 8, };
            array3[1][1] = new int[2] { 9, 10 };
            array3[1][2] = new int[2] { 11, 12 };

            for (int i = 0; i < array3.Length; i++)
            {
                for (int j = 0; j < array3[i].Length; j++)
                {
                    for (int k = 0; k < array3[i][j].Length; k++)
                    {
                        Console.Write("{0} ", array3[i][j][k]);
                    }
                }
            }
        }
    }
    */

    /*
    class Program
    {
        static void TransArray(string[] arr)
        {
            string[] HangulDays = { "일", "월", "화", "수", "목", "금", "토" };
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = HangulDays[i];
            }
        }

        static void Main(string[] args)
        {
            string[] Days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            TransArray(Days);
            foreach (string str in Days)
                Console.Write(str);
        }
    }
    */

    /*
    class Program
    {
        static int[] CreateArray1(int nSize)
        {
            int[] Array1 = new int[nSize];
            for (int i = 0; i < Array1.Length; i++)
                Array1[i] = i;
            return Array1;
        }

        static int[,] CreateArray2(int nRow, int nCol)
        {
            int index = 0;
            int[,] Array2 = new int[nRow, nCol];
            for (int i = 0; i < nRow; i++)
                for (int j = 0; j < nCol; j++)
                    Array2[i, j] = index++;
            return Array2;
        }

        static void Main(string[] args)
        {
            int[] nArray1;
            int[,] nArray2;

            nArray1 = CreateArray1(5);
            nArray2 = CreateArray2(2, 3);

            for (int i = 0; i < nArray1.Length; i++)
                for (int j = 0; j < 3; j++)
                    Console.Write(nArray2[i, j]);
            Console.WriteLine();
        }
    }
    */

    /*
    class Program
    {
        static void Main(string[] args)
        {
            int[] nArray1 = { 1, 2, 3, 4 };
            int[] nCloneArray = (int[])nArray1.Clone();

            nCloneArray[2] = 30;
            foreach (int m in nArray1)
                Console.Write(m);
            Console.WriteLine();

            foreach (int m in nCloneArray)
                Console.Write(m);
            Console.WriteLine();
        }
    }
    */


}