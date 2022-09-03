// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое целое число");
string input1 = Console.ReadLine(); // пользовательский ввод
Console.WriteLine("Введите второе целое число");
string input2 = Console.ReadLine(); // пользовательский ввод
Console.WriteLine("Введите третье целое число");
string input3 = Console.ReadLine(); // пользовательский ввод

int num1 = int.Parse (input1);
int num2 = int.Parse (input2);
int num3 = int.Parse (input3);

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max= ");
Console.WriteLine(max);

