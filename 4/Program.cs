Console.Clear();
Console.Write("Введите число: ");
string stringNumber = Console.ReadLine();
int endNumber = int.Parse(stringNumber);
int number = 0;

Console.WriteLine($"Чётные числа из диапазона от 1 до {endNumber}:");

while (number < endNumber)
{
    number++;
    if (number % 2 == 0) Console.Write($"{number} ");
}
