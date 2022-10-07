/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

int InputMessage(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1}-ое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива: ");

    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
}

int QuantityPozitiveNumbers()
{
    Console.Clear();
    int size = InputMessage("Какое количество чисел будет введено? ");
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();

    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine($"Количество введённых чисел больше нуля равно: {QuantityPozitiveNumbers()}");