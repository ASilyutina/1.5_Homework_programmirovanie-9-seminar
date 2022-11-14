// 9.4 Написать программу возведения числа А в целую стень B

int Power(int A, int B)
{
    if (B == 0) return 1;
    else return Power(A, B - 1) * A;
}

int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int A = ReadIntegerNumber("Input A: ");
int B = ReadIntegerNumber("exponent for raising a number A: ");

Console.WriteLine(Power(A,B));