// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// int result_deg=0;
int degree(int A, int B)
{
    
    int result_deg = 1;
    for (int i = 0; i < B; i++)
    {
        result_deg = result_deg * A ;
        
    } 
    return result_deg;
}

Console.Write("Введите первое число:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int y= Convert.ToInt32(Console.ReadLine());
Console.Write(degree(x,y));