// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackermann(int m, int n)

{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
Console.WriteLine($"Функция Аккермана равно {Ackermann(m, n)} ");

