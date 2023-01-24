// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
int count = 0;
int countNum(int numA)
{   
    // int count = 0;
    while (numA != 0)
    {
        numA = numA / 10;
        count += 1;
    }
    return count;
}

int sumNum (int numA, int lenght) 
{
    int length = count;
    int result = 0;
    for (int i = 0; i <=lenght; i++)
    {
        result +=  numA % 10;
        numA = numA / 10;
    }
    return result;
}
Console.Write("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(countNum(82));
Console.WriteLine($"Сумма цифр = {sumNum(x,countNum(x))}");

// Console.WriteLine();