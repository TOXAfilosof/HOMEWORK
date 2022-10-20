/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if(max > n2)
{
    Console.WriteLine($"Max = {n1}");
}
else
{
    Console.WriteLine($"Max = {n2}");
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    if(n1 > n3)
    {
    Console.WriteLine($"Max = {n1}");
    }
    else
    {
      Console.WriteLine($"Max = {n3}");  
    }
}

else if(n2 > n3)
{
    Console.WriteLine($"Max = {n2}");
}
else
{
    Console.WriteLine($"Max = {n3}");
}
*/

//Задача 6:Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if(n1 % 2 == 0)
{
    Console.WriteLine($"{n1} -> even");
}
else
{
    Console.WriteLine($"{n1} -> not even");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
int i = 1;
bool not = true;

Console.Write("Input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("even numbers: " + n1);
while (i <= n1)
    {
    if (i % 2 != 1)
        {
        Console.Write(i + ", ");
        not = false;
        }
    i ++;
    }

    if (not)
    {
    Console.WriteLine("There are no even numbers!");
    }
*/

