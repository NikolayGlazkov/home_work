Console.WriteLine("введите число №1");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число №2");
int num2 = int.Parse(Console.ReadLine());

int exponent = 2;
double result = Math.Pow(num2, exponent);
Console.WriteLine(result);


if(num1 == result)
{
    Console.WriteLine($"Число №1: {num1} евляеться квадратом второго: {num2}");
}
if(num1 != result)
{
    Console.WriteLine($"Число №1: {num1} не евляеться квадратом второго: {num2}");
}