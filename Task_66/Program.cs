// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumRec(int m, int n)
{
    if (m == n)
        return m;
    else
        return SumRec(m + 1, n) + m;
}


Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма от {m} до {n}: {SumRec(m, n)}");
