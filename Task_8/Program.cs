int num;
Console.Write("Enter a number: ");
num = int.Parse(Console.ReadLine());
int firstDigit = num / 100; // Получаем первую цифру
int thirdDigit = num % 10; // Получаем третью цифру
int newNum = firstDigit * 10 + thirdDigit; // Собираем новое число
Console.WriteLine(newNum); // Выводим новое число