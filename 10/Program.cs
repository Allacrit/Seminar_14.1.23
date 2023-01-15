Console.Clear();
Console.WriteLine("Найти третью цифру числа или сообщить, что её нет");
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if ((number / 100) > 0)
{
    Console.WriteLine($"Третьей цифрой числа {number} является цифра {number / 100 % 10}.");
} 
else
{
    Console.WriteLine($"У числа {number} нет третьей цифры.");
}