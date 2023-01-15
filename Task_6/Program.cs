// Показать вторую цифру трёхзначного числа

int n;
Console.Write("Enter a number: ");
n = int.Parse(Console.ReadLine());

int secondDigit = (n / 10) % 10;
Console.WriteLine(secondDigit);