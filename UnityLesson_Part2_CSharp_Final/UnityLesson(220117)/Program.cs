using System;

namespace UnityLesson_220117_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"22/7 = {22/7}({22%7})");       //{}괄호를 사용하는 이유는 $를 써서 계산값을 직접 입력해주기 위해

            int a = 1;      // 증감 연산자
            a = a + 1;
            a += 1;
            ++a;

            Console.WriteLine(1>2);       // 비교 연산자
            Console.WriteLine(1<=2);
            Console.WriteLine(1==2);
            Console.WriteLine(1!=2);

            
        }
    }
}


/*
 string s = Console.ReadLine();       실습1
 int num = int.Parse(s);
 if(num > 0)
    Console.WriteLine("True");
 if(num <= 0)
    Console.WriteLine("False");

 double kor = 87.5;                   실습2
 double eng = 97.5;
 double sum = kor + eng;
 double avg = sum / 2;

 Console.WriteLine($"총점 {sum}");
 Console.WriteLine($"평균 {avg}");

 Console.WriteLine((char)105);        실습3

 for (int i = 0; i < 10; i++)         실습4(포문)
  {
  Console.WriteLine(i);
  }

 for (char i = '가'; i < '힣'; i++)
 {
     Console.Write(i);
 }


 Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));      실습5 날짜구하기  // 연월일
 Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));          // 시분초

 TimeSpan ts = DateTime.Now - new DateTime(2000, 1, 1);         // 현재까지 날짜 계산하기
 Console.WriteLine(ts.TotalDays);
 
 string s = "of the people, by the people, for the people";     실습6   //배열, 분할해서 출력하기
 
 string[] ss = s.Split(",");
 
 foreach (var item in ss)
 {
     Console.WriteLine(item);
 }


 Console.WriteLine($"22/7 = {22/7}({22%7})");      실습7  //{}괄호를 사용하는 이유는 $를 써서 계산값을 직접 입력해주기 위해
 
 int a = 1;                   // 증감 연산자
 a = a + 1;
 a += 1;
 ++a;

 Console.WriteLine(1>2);       // 비교 연산자(true, false로만 나타남)
 Console.WriteLine(1<=2);
 Console.WriteLine(1==2);
 Console.WriteLine(1!=2);

 Console.WriteLine(1<2 && 2<3);    // 그리고 and
 Console.WriteLine(1>2 || 2>3);    // 또는 or

 int a = 30;
 string result = (a<1)? "A" : "B";      //참이면 앞에글씨 출력(A), 거짓이면 뒤에글씨 출력(B)

*/