// 9.1 Показать натуральные числа от M до N, N и M заданы


string number(int N, int M)
{
    if (N>=M) return number(N -1, M) + $"{N} ";
    else return " ";
}
 

Console.WriteLine(" Input M ");
int M = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine(" Input  N ");
int N = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine($"Natural numbers: {number(N,M)}");