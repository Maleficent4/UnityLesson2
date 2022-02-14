using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityLesson_220214_
{
    class Program
    {

        // Random만들기

        static void Main(string[] args)
        {
            
        }



       

    }
}


/*

       // 절대값 구하기  
        static void Main(string[] args)
        {
            int num = -5;
            Console.WriteLine( Abs(num) );

        }

        static int Abs(int a)
        {
            if (a < 0) return -a;
            return a;
        }

        static void Abs(ref int a)   // a == num
        {
            if (a < 0) a = -a;
        }



       // [String] 두개의 문자열을 입력하면, 두 문자열에 모두 포함된 문자만으로 구성된 문자열을 반환하는 함수를 작성하시오.
       static void Main(string[] args)
       {
           string s1 = "123456";
           string s2 = "456789";
           Console.WriteLine(CommonString(s1, s2));
        }
       
       static string CommonString(string s1, string s2)    // 위에 s1, s2와 전혀다른 공간에 있기때문에 이름이 같아도 상관없다.
       {
           string s = "";
           for (int i = 0; i < s1.Length; i++)
           {
               if (s2.Contains(s1[i].ToString()))
                   s += s1[i].ToString();
           }
       
           return s;
        }



        // 두 정수를 매개변수로 전달하여, 두 정수의 합을 구하는 함수를 작성하라(out 출력 전용 매개 변수 활용)
        static void Main(string[] args)
        {
            Sum(3, 5, out int rt);
            Console.WriteLine(rt);
         }

        static void Sum(int a, int b, out int sum)
        {
            sum = a + b;
        }



        // 두 정수를 매개변수로 전달하여, 두 정수의 합을 구하는 함수를 작성하라(out 출력 전용 매개 변수 활용
        // 단, 합이 0보다 작으면 false를 아니면 true를 반환합니다.
        static void Main(string[] args)
        {
            bool result = Sum(3, 5, out int rt);
            Console.WriteLine(rt);
         }

        static bool Sum(int a, int b, out int sum)
        {
            sum = a + b;
            if (sum < 0) return false;
            return true;
        }


        // 2개의 정수를 입력 받아 더하는 코드를 작성하세요
        // 입력한 값이 정수가 아니면 다시 입력을 받으세요. int.TryParse()사용
        static void Main(string[] args)
        {
            int a = GetInt();
            int b = GetInt();
            Console.WriteLine( a+b );
        }

        public static int GetInt()  
        {
            int result;
            while (! int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("다시 입력하세요");
            }
            return result;
        }



        // 여러개의 문자열을 입력값으로 받아, 가장 길이가 큰 문자열을 반환하는 함수를 작성하세요. (params)

        static void Main(string[] args)
        {
            MaxString("aaa", "bb");
            // 출력할때 Console.WriteLine(MaxString("aaa", "bb", "sksksksksksksksksksskk"));
            MaxString("aaa", "bb", "sksksksksksksksksksskk");
        }

        static string MaxString(params string[] arr)  
        {
            string s = "";
            int max = 0;
            int max_index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > max)
                {
                    max = arr[i].Length;
                    max_index = i;
                }
            }
        
            s = arr[max_index];
            return s;
        }



        // 여러개의 문자열을 입력값으로 받아 문자열 리스트로 반환하는 함수를 작성하세요

        static void Main(string[] args)
        {
            List<string> s = MaxString("adfadf", "adfeerddd", "dfld");

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }

        static List<string> MaxString(params string[] arr)  
        {
            List<string> list = new List<string>();

            foreach (var item in arr)
            {
                list.Add(item);
            }

            return list;
        }



       // Sum(1); Sum(1,2); 의 결과가 모두 3이 출력되도록 Sum 함수를 작성하세요
       // (선택적 매개변수 활용)

       static void Main(string[] args)
       {
           Sum(1);
           Sum(1, 2);
       }

       static void Sum(int a, int b = 2)
       {
           Console.WriteLine( a+b );
       }



        // Random만들기

        static void Main(string[] args)
        {
            Random random = new Random();
            int rand = random.Next() % 10;
            Console.WriteLine(rand);

        }


*/
