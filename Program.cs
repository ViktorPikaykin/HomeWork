// Урок 1. Знакомство с языком программирования С#

// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    Console.WriteLine(num1 + "-max " + num2 + "-min");

else
    Console.WriteLine(num1 + "-min " + num2 + "-max");
*/

// Задача 4: Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)
    max = num2;

if(num3 > max)
    max = num3;

Console.WriteLine("number " + max + " maximum ");
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a namber ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num % 2;

if(current == 0)
    Console.WriteLine("Yes!");
else
    Console.WriteLine("No!");
*/

// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input a namber: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= num)
    Console.Write(current + " ");
    current = current + 2;
*/
