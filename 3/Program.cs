Console.Clear();
Console.WriteLine("Выяснить является ли число чётным.");
Console.Write("Введите число: ");
string writeNumber = Console.ReadLine();
int number = int.Parse(writeNumber);
string result = $"Число {number} является чётным!";

if (number % 2 != 0) result = result.Replace("является", "не является");

Console.WriteLine(result);