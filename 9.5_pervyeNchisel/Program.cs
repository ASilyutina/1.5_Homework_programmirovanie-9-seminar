// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем


void PrintNumber(int numberFirst, int numberSecond, int score)
{
    int temporary = 0;
    if (score > 0)
    {
        Console.Write(numberFirst + numberSecond + " ");
        temporary = numberFirst;
        numberFirst =numberSecond;
        numberSecond += temporary;
        PrintNumber(numberFirst, numberSecond, score -= 1);
    }
}
int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int numberFirst = GetNumber("input M: ");
int numberSecond = GetNumber("inputN: ");
int score = GetNumber("Enter the number of times how many times we will display the number: ");
PrintNumber(numberFirst, numberSecond, score);
