// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите любое положительное число:");
int N = int.Parse(Console.ReadLine()!);

// пишем функцию нахождения куба
void TableCubesNumbers()
{
    double Count = 1;
    double Cub = 1;
    while (Count <= N)
    {
        Cub = Math.Pow (Count,3); // Встроенная функция возведения в степень, где 3- куб
        Count++;
        Console.Write(Cub + ", ");
    }
}

// вызываем функцию кубов
 TableCubesNumbers();

