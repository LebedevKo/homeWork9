// задайте значения M и N. 
//Написать программу, к-я выведет все натуральные числа в промежутке от  M до N
/*


*/

// решение через массив
// Console.WriteLine("введите первое число: ");
// int  start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите второе число: ");
// int end = Convert.ToInt32(Console.ReadLine());

// string Rec(int start, int end);
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + Rec(start + 1, end));

// }
// Console.WriteLine(Rec(1,5)); // не получилось


//напишите программу, к-я будет принимать на вход число и возвращать сумму его цифр
/*
Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumOfDigits(number);
Console.WriteLine("Сумма цифр числа: " + sum);

int SumOfDigits(int n)
{
    if (n < 10)
    {
        return n;
    }
    else
    {
        int lastDigit = n % 10;
        int remainingDigits = n / 10;
        return lastDigit + SumOfDigits(remainingDigits);
    }
}
*/


// наисать прогу, к-я на вход принимает два числа А и Б,
// и возводит число А в целую степень Б с помощью рекурсии

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень B: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = Power(A, B);
Console.WriteLine("Результат: " + result);
    
int Power(int A, int B)
{
    if (B == 0)
    {
        return 1;
    }
    else
    {
        return A * Power(A, B - 1);
    }
}