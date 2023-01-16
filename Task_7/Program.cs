// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа


int n = 99;
int maxDigit = 0;

for (int i = 10; i <= n; i++)

{
if(i > maxDigit)
    maxDigit = i;
}

Console.WriteLine("Max digit is: " + maxDigit);