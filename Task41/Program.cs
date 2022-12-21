// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] EnterData(int [] array)
{
    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine());
    array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        array[i] = int.Parse(Console.ReadLine());  
    }
        return array;
}

void FindPositive(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    Console.Write($"[{string.Join(",", array)}] -> {count}");
}

int [] array = {};
array = EnterData(array);
FindPositive(array);


