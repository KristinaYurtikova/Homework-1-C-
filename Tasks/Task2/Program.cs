// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int num1 = 2;
int num2 = 3;
int num3 = 7;

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max= ");
Console.WriteLine(max);

int num4 = 44;
int num5 = 5;
int num6 = 78;

int max2 = num4;

if (num4 > max) max = num4;
if (num5 > max) max = num5;
if (num6 > max) max = num6;

Console.Write("max= ");
Console.WriteLine(max);

int num7 = 22;
int num8 = 3;
int num9 = 9;

int max3 = num7;

if (num7 > max) max = num7;
if (num8 > max) max = num8;
if (num9 > max) max = num9;

Console.Write("max= ");
Console.WriteLine(max3);