/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

void InputMessage_FillArray(string message, double[] massiv)
{
    Console.Write(message);

    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = Convert.ToDouble(Console.ReadLine());
    }
}

void FindPoint()
{
    Console.Clear();
    double[] numbers = new double[4];

    InputMessage_FillArray("Введите попеременно координаты точек двух прямых: ", numbers);
    Console.WriteLine();

    double x = (numbers[2] - numbers[0]) / (numbers[1] - numbers[3]);
    double y = numbers[3] * x + numbers[2];
    double y1 = numbers[1] * x + numbers[0];

    Console.WriteLine($"Точка пересечения двух прямых имеет координаты: ({x}; {y})");
}

FindPoint();