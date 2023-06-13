// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 <= number2)
{
    int sum = CalculateSum(number1, number2);
    Console.WriteLine($"Сумма натуральных чисел в диапазоне от {number1} до {number2}: {sum}");
}
else
{
    int sum = CalculateSum(number2, number1);
    Console.WriteLine($"Сумма натуральных чисел в диапазоне от {number2} до {number1}: {sum}");
}

int CalculateSum(int start, int end)
{
    if (start <= end)
    {
        return start + CalculateSum(start + 1, end);
    }
    else
    {
        return 0;
    }
}
