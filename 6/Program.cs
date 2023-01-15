Console.Clear();
Console.WriteLine("Показать вторую цифру трёхзначного числа.");
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

if(number < 1000 && number > 99)
{
Console.WriteLine($"Второй цифрой числа {number} является цифра {number / 10 % 10}.");
}
else
{
Console.WriteLine($"Число {number} не является ТРЁХЗНАЧНЫМ!!");
}