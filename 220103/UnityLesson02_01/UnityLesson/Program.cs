using System;

namespace UnityLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World! ");
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello\nWorld");
            Console.WriteLine("Hello\tWorld");
            Console.WriteLine("\"HelloWorld\"");
            Console.WriteLine(@"!@HelloWorld$#$#$");

            int num = 10;
            Console.WriteLine($"Hello World {num}");

            string aaa = Console.ReadLine();
            Console.WriteLine("input: " + aaa);

            

        }
    }

    class Program2   // 파랑색으로 나오는 애들은 키워드, 옆에 있는 이름은 식별자
    {
        //변수(데이터)
        //변수는 타입(형태) 이름 = 값;
        int a = 0;

        //함수(기능, 코드덩어리)
        //함수는 타입(반환) 이름(입력할 변수) {     }
        //괄호가 있으면 무조건 함수
        //void는 반환할게 없다는 뜻


        int Add(int a, int b)
        {
            return a + b;
        }

    }
}
