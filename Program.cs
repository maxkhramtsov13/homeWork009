/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.
*/
#region 
int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void AmountOfNumbers(int num, int end)
{
    if(num == end) return;
    AmountOfNumbers(++num, end);
    Console.Write(num + " ");
}

int num = InputNumber(" Введите начальное число: ");
int end = InputNumber(" Введите конечное число: ");
AmountOfNumbers(num, end);
#endregion
/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
*/
#region 
int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumNumber(int min, int max)
{
    if(min > max)return 0;
    return min + SumNumber(++min, max);
}

int min = InputNumber(" Введите начальное число: ");
int max = InputNumber(" Введите конечное число: ");
int sumNum = SumNumber(min, max);
Console.WriteLine(" Сумма чисел: " + sumNum);
#endregion
/*
Напишите программу вычисления функции Аккермана
 с помощью рекурсии. Даны два неотрицательных числа m и n.
*/
#region 
int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Akkerman(int m, int n)
{
    if(m == 0)return n + 1;
    else if(n == 0)
    return Akkerman(m - 1, 1);
    else
    return Akkerman(m - 1, Akkerman(m, n -1));
}

int m = InputNumber(" Введите начальное число: ");
int n = InputNumber(" Введите конечное число: ");
int akker = Akkerman(m, n);
Console.WriteLine(" Сумма чисел: " + akker);
#endregion