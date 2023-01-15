Console.Clear();
Console.WriteLine("Показать наибольшую цифру введённого числа на отрезке от 10 до 99.");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int max = 0;
if(number < 10 || number > 99)
{
    Console.WriteLine($"Число {number} не входит в диапазон данного отрезка.");
}
else
{
    MaxDigitFunction();
    Console.WriteLine($"В числе {number} наибольшая цифра {max}");
}

int MaxDigitFunction()
{
    int digitOne = number / 10;
    int digitTwo = number % 10;
    if (digitOne > digitTwo) 
        {
        max = digitOne;
        }
    else
        {
        max = digitTwo;
        }
    return max;
}

