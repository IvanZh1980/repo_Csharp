﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int tempNumber = number; //число, которое мы будем делить на 10

int reversedNumber = 0; //развернутое число
while(tempNumber > 0)
{
int digit = tempNumber % 10;
reversedNumber = reversedNumber * 10 + digit;
tempNumber = tempNumber / 10;
}
if(reversedNumber == number)
{
Console.WriteLine($"Развернутое число = {reversedNumber} - палиндром");
}
else
Console.WriteLine($"Развернутое число = {reversedNumber} - НЕ палиндром");


