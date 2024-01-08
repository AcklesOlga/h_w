using System;
int N = 15689;
while (N > 10)
{
    int currentD = N % 10;
    N = N / 10;

    {
        Console.Write(currentD + ",");
    }
}

if (N < 10)
{
    Console.WriteLine(N);
}
