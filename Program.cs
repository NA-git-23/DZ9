// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// Console.WriteLine($"Натуральные числа в промежутке от {number} до 1:  ");
// Numbers(number, count);
// Console.WriteLine();



// void Numbers(int n, int count)
// {
//    {
//     if (count > n)
//     {
//         return;
//     }
//     else
//     {
//         Numbers(n, count + 1);
//         Console.Write(count + " ");
//     }
// }
// }











// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n}:  ");
// Console.Write(Sum(m - 1, n));
// Console.WriteLine();


// int Sum(int m, int n)
// {
//     int result = 0;
//     if (m == n)
 
//         return 0;
            
//     else
//     {
//         m++;
//         result = m + Sum(m, n);
//         return result;
//     }
// }



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите число M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Вычисление Аккермана:  ");
Console.Write(Ack(n,m));
Console.WriteLine();


int Ack(int n, int m)
   {
    if (n == 0)
     {return m + 1;}
   else if (m == 0 )
     {return Ack (n - 1, 1);}
   else
     {return Ack(n - 1, Ack (n, m - 1));}
   }