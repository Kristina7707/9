// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine ("Введите число М ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} "); 

void NumberSum (int m, int n, int sum)
{

    if (m > n) 

         { Console.Write($" = {sum}");
        return;
    }
    sum = sum + (m++);
    NumberSum(m, n, sum);
}

 NumberSum(m, n, 0);