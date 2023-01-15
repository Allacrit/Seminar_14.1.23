Console.Clear();
Console.WriteLine("Показать четные числа от 1 до N.");
Console.Write("Введите число вместо N: ");
string stringNumber = Console.ReadLine();
int endNumber = int.Parse(stringNumber);
int number = 0;

Console.WriteLine($"Чётные числа из диапазона от 1 до {endNumber}:");

while (number < endNumber)
{
    number++;
    if (number % 2 == 0) Console.Write($"{number} ");
}
