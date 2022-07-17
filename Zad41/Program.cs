/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

void CreateArray(int [] array)
{
    int sizeNum = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {sizeNum}е число");
        array [i] = Convert.ToInt32(Console.ReadLine());
        sizeNum ++;
    }
}

void FindCollPositive(int [] array)
{
    int colPos = 0;
    for (int i = 0; i< array.Length; i++)
    {
        if(array [i] > 0)
        {
            colPos++;
        }
    }
    Console.WriteLine($"Количесто положительных чисел составляет: {colPos}");
}

Console.WriteLine("Сколько чисел хотите ввести?");
int arraySize = Convert.ToInt32(Console.ReadLine());
int [] array = new int [arraySize];
CreateArray(array);
Console.WriteLine($"Введеные числа: [{String.Join(";", array)}]");
FindCollPositive(array);


