// void Arr(int count)
// {
//     int[] array;
//     if (count <= 8)
//     {
//         array = new int[count];
//         for (int i = 0; i < array.Length; i++)
//         {
//             array[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         Console.WriteLine($"[{string.Join(",", array)}]");

//     }

//     else
//     {
//         Console.Write("Максимальное колличество элементов 8.");
//     }
//     return array;
// }

int Arr(int enterNumber, int[] array)
{
    for (int i = 0; i < enterNumber; i++)
    {
        array[i] = new Random().Next(enterNumber + 1);
        Console.Write(array[i] + "; ");
    }
    return array;
    Console.WriteLine();
}
Console.WriteLine("Будет создан массив длиной A в диапвзоне 0-A");
Console.Write("Введите любое число (A): ");
int enterNumber = Convert.ToInt32(Console.ReadLine());
int[] array = new int[enterNumber];
Arr(8, array);
