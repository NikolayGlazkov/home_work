// Показать последнюю цифру трёхзначного числа

int n;
int last_digit = 0;
Console.Write("Enter a number: ");
n = int.Parse(Console.ReadLine());

last_digit = n % 10;

    Console.WriteLine($"Последнее число {last_digit}");

