using System;
int a = 64;
if (a > 10 && a < 99)
{
    int firstD = a / 10;
    int secondD = a % 10;
    Console.WriteLine(Math.Max(firstD, secondD));
}
else
{
    Console.WriteLine ("Используйте число в отрезке [10; 99]");
}