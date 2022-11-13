// 9.2 Найти сумму элементов от M до N, N и M заданы


int M = AskNumber("M");
int N = AskNumber("N");
Console.WriteLine($"M = {M}; N = {N} -> {PrintSum(M, N)}");

static int PrintSum(int M, int N) {
    if(M > N) {
        return 0;
    }
    return M + PrintSum(M + 1, N);
}

static int AskNumber(string name) {
    Console.Write($"Input number {name}: ");
    return int.Parse(Console.ReadLine());
}
