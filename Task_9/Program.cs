// Выяснить, кратно ли число заданному, если нет, вывести остаток.


int num1;
int num2;
int ost;

Console.Write("Enter a number №1:");
num1 = int.Parse(Console.ReadLine());
Console.Write("Enter a number №2:");
num2 = int.Parse(Console.ReadLine());
ost = num1 % num2;

if(num1 % num2 == 0)
{
    Console.WriteLine($"Число №2: {num2} кратно числe №1 {num1}");
}
if(num1 % num2 != 0)
{
    Console.WriteLine($"Выяснить,Число №2: {num2} не кратно числу №1 {num1} остаток от деления = {ost}");
}