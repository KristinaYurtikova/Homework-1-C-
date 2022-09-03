// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое целое число");
string input1 = Console.ReadLine(); // пользовательский ввод
Console.WriteLine("Введите второе целое число");
string input2 = Console.ReadLine(); // пользовательский ввод

int num1 = int.Parse (input1);
int num2 = int.Parse (input2);

if(num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}
    
