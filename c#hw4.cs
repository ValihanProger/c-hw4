// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// Console.Write("Введите колличество чисел :");
// int y = Convert.ToInt32(Console.ReadLine());


string Arr(int count)
{

    string x = "";
    if (count <= 8)
    {
        int[] array = new int[count];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(count);

        }
        x = string.Join(", ", array);


    }

    else
    {
        Console.Write("Максимальное колличество элементов 8.");
    }
    return x;
}
Console.Write("Введите колличество чисел :");
int result = Convert.ToInt32(Console.ReadLine());
Console.Write(Arr(result));