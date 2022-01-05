using System;

namespace UnityLesson02
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            var n1 = 1;
            var n2 = 1.0;
            var n3 = hello;

        }
    }
}

/* 1 합계와 평균
static void Main(string[] args)
{
int a = 10;
int b = 30;
double c = 2.5;
double total = a + b + c;

Console.WriteLine(total);
Console.WriteLine(total / 3);
}
*/

/* 2 $사용
static void Main(string[] args)
{
int a = 10;
Console.WriteLine($"a={a}");
}
*/

/* 3 형변환
static void Main(string[] args)
{
int n = (int)1.5; // 얘는 강제 형 변환, 명시적 형변환
double d = 3;     // 자동 형 변환, 암시적 형변환

string a = Console.ReadLine();
string b = Console.ReadLine();
// Console.WriteLine(a + b);      이렇게하면 숫자를 더하는게 아니라 그냥 입력 문자를 붙여버린다.

int x = int.Parse(a);          // 숫자는 입력하고 리턴이 안된다, ReadLine은 string타입을 출력하는거라서 string으로 만들고 형변환을 해줘야한다.
int y = int.Parse(b);
Console.WriteLine(x + y);

int n = 10;
string s = n.ToString();     // 숫자 -> 문자 변환 
}
*/

/* 4 복합자료형
static void Main(string[] args)
{
int[] arr = { 1,2,3,4,5,6,7,8,9,10 };
Console.WriteLine( arr[6] );                // 배열, 항상 0 부터 시작
}
*/

/* 5 char와 2진수, 16진수
char ch = 'A';     // char는 아스키코드, 유니코드로 텍스트는 숫자다
Console.WriteLine((int)ch);

int number1 = 0b1111;
int number2 = 0xF;
Console.WriteLine(number2);
*/

/* 6 상수와 변수
enum Result2
{
YES,    // 0      열거형, 항상 0 부터 시작, static 밖에 작성 아예 상수로 지정하는 방법 만약 YES = 100, 이렇게 시작하면 YES는 100이되고 뒤에건 101이 된다.
NO,     // 1
CANCEL  // 2
}

static void Main(string[] args) 
{
 const double PI = 3.14;     // 변수를 상수라고 선언했다. 그래서 아래에 에러가 남.
 PI = 3.15;
 Console.WriteLine(PI);
 }
*/




