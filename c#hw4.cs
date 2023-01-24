// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число 
// A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Square(int a, int b)
{
    int c = 0;
    int k = 0;
    for (int i = 0; k <= b; i++)
    {
        c = a*b;
        k++;
        Console.WriteLine(c);
    }


    return c;
}


Square(3,5);