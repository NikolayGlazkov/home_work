// Найти третью цифру числа или сообщить, что её нет


int num1;
int thirdDigit;

Console.Write("Enter a number №1:");
num1 = int.Parse(Console.ReadLine());
thirdDigit = num1 % 10;

if(num1 <= 99)
{
    Console.WriteLine($" в заданном числе 2 цифры");
}
if(num1 >= 100)
{
    Console.WriteLine($"третья цифра числа: {thirdDigit}");
}