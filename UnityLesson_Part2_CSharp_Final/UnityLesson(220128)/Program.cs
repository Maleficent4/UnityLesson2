using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityLesson_220128_
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("숫자를 입력하세요(0이면 종료): ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                    break;

            }



        }
    }
}




/*
int[] array = { 0, 1, 2, 3, 4 };                              // 숫자 배열


foreach (var item in array)
{
    Console.WriteLine(item);
}


string[] cities = { "서울", "부산", "나주" };                 // 문자열 배열

foreach (var item1 in cities)
{
    Console.WriteLine(item1);
}


int[] array2 = { 7, 2, 6, 1, 4 };                              // 소팅하기(순서 정렬)

Array.Sort(array2);

foreach (var item2 in array2)
{
    Console.WriteLine(item2);
}


List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

foreach (var item3 in list)
{
    Console.WriteLine(item3);
}


List<string> names = new List<string>() { "김개똥", "김아무개", "고길동" };       // 리스트

names.Add("홍길동");                                            // 추가하기
names.Remove("고길동");                                         // 삭제하기

foreach (var item4 in names)                                    // 포이치문으로 만들기
{
    Console.WriteLine(item4);
}

for (int i = 0; i < names.Count; i++)                           // 포문으로 만들기
{
    Console.WriteLine(names[i]);
}



int number = int.Parse(Console.ReadLine());        // 실습1

if (number >= 90)
{
    Console.WriteLine("success");
}


int score = int.Parse(Console.ReadLine());                 // 실습2

if (score >= 90)
    Console.WriteLine("A");
else if (score >= 80)
    Console.WriteLine("B");
else if (score >= 70)
    Console.WriteLine("C");
else
    Console.WriteLine("F");


int grade = 0;                                             // 실습3
switch (grade)
{
    case 1: Console.WriteLine("Excellent");
        break;
    case 2:
    case 3: Console.WriteLine("Great");
        break;
    default: Console.WriteLine("Good");
        break;
}


*/