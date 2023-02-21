// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// пишем функцию нахождения куба
string TableCubesNumbers(int n)
{
    double Count = 1;
    double Cub = 1;
    string result = "";
    while (Count <= n)
    {
        Cub = Math.Pow(Count, 3); // Встроенная функция возведения в степень, где 3- куб
        Count++;
        result = result + Cub + ",";
        //Console.Write(Cub + ", ");
    }
    return result;
}
Console.WriteLine("Введите любое положительное число:");
int N = int.Parse(Console.ReadLine()!);
// вызываем функцию кубов
string cub2 = TableCubesNumbers(N);
Console.WriteLine(cub2);

