using System;

namespace _220124
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            
            
            
            
            





        }
    }
}

/*
int score = int.Parse(Console.ReadLine());                   // if문 실습

if(score >= 90)
    Console.WriteLine("A");
else if(score >= 80)
    Console.WriteLine("B");
else if(score >= 70)
    Console.WriteLine("C");
else
    Console.WriteLine("F");


int score = int.Parse(Console.ReadLine());

switch(score)                                   // switch 문은 비교에는 적합하지 않음, if문과 비슷하지만 조건을 조금 더 정확하게 줘야함
{
    case 100:
        Console.WriteLine(100);
        break;
    case 90:
        Console.WriteLine(90);
        break;
    case 80:
        Console.WriteLine(80);
        break;
    default:
        break;
}


for (int i = 0; i < 10; i++)                       //for문, 반복문
{
    Console.WriteLine("안녕" +i);
}

for (int i = 1; i <= 10; i++)               // 1부터 10까지 홀수와 짝수를 구분하라
{
    if(i%2==0)
    Console.WriteLine("짝수");
    else
    Console.WriteLine("홀수");
}


int i = 0;                                  //while문, 계속 반복하는 놈
while (i<10) 
{
    Console.WriteLine(0);
    i++;
}


int[] array = { 1, 2, 3, 4, 5, 6 };                //배열 사용하기
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

for (int i = array.Length -1; i >= 0; i--)
{
    Console.WriteLine(array[i]);
}

foreach (var item in array)
{
    Console.WriteLine(item);
}



string[] Regions = { "서울", "경기", "부산" };

for (int i = 0; i < Regions.Length; i++)
{
    Console.WriteLine(Regions[i]);
}

foreach (var item in Regions)
{
    Console.WriteLine(item);
}


for (int dan = 1; dan <= 9; dan++)                     //구구단, 이중 포문 사용하기      // break는 for문 밖으로 나가버리는것, continue는 skip의미를 가짐
{ 
    for (int i = 1; i <= 9; i++)
    {
        Console.WriteLine($"{i} * {dan} = {i*dan}");
    }
}


Console.WriteLine("1");          //goto문 강력한놈 쓰지말라
Console.WriteLine("2");
goto A;
Console.WriteLine("3");
Console.WriteLine("4");
A:
Console.WriteLine("5");

*/