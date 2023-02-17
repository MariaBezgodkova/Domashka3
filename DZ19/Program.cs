﻿// Задача 19
//Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


//создаем метод проверки на палиндром пятизначного числа
void Palindrom(int i)
{
    if (i / 10000 == i % 10 && i / 1000 % 10 == i % 100 / 10)
    {
        Console.WriteLine("Ваше число является палиндромом");
    }
    else
    {
        Console.WriteLine("Ваше число не является палиндромом");
    }
       
}
Console.WriteLine("Введите пятизначное число:");
int i = int.Parse(Console.ReadLine()!);
Palindrom (i);


