Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

if(number < 1000 || number > 99)
{
Console.WriteLine($"Последней цифрой числа {number} является цифра {number%10}.");
}
else
{
Console.WriteLine($"Число {number} не является ТРЁХЗНАЧНЫМ!!");
}