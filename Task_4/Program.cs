// Показать четные числа от 1 до N

int n;
Console.Write("Enter a number: ");
n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)

if(i % 2 == 0)
{
    Console.WriteLine($"чесло {i} являеться четным");
}
