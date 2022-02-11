using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityLesson_220211_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Swap(a, b);
            Console.WriteLine(a + "" + b);

        }
        
        static void Swap(int x, int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

    }



}


/*
        int Add(int a, int b)            // int (int,int)
        {
            Console.WriteLine(a+b);
            return a + b;
        }

        void AddPrint(int a, int b)      // void(int,int)
        {
            Console.WriteLine(a+b);
        }

        int StringLength(string s)       // 문자 길이 함수 선언
        {
            return s.Length;
        }
 

// 뭔지 모르겠지만 12 출력되는 함수
static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Swap(a, b);
            Console.WriteLine(a + "" + b);

        }
        
static void Swap(int x, int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

*/
