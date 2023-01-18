//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int AkkF(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkkF(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AkkF(m - 1, AkkF(m, n - 1));
    }
    else
        return n + 1;
}
Console.WriteLine();
Console.Write("Введите число m: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numN = Convert.ToInt32(Console.ReadLine());
if (numM >= 0 && numN >= 0)
    Console.WriteLine($"m = {numM}, n= {numN} -> A(m,n) = {AkkF(numM, numN)}");
else Console.WriteLine("Введите неотрицательные числа m и n!");
Console.WriteLine();