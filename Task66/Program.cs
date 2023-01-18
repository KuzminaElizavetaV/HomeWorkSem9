// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int PrintSumNumbersFrom(int start, int end)
{
    int sum = start;
    if (start < 0 && end < 0) return sum = 0;
    if (start < end)
    {
        while (start < 0)
        {
            start++;
        }
        sum = start + PrintSumNumbersFrom(start + 1, end);
    }
    if (start > end && start > 0) sum = start + PrintSumNumbersFrom(start - 1, end);
    return sum;
}
if (numberM == numberN) Console.WriteLine("Сумма натуральных элементов равняется 0");
else Console.WriteLine($"Сумма натуральных элементов равняется {PrintSumNumbersFrom(numberM,numberN)}");
