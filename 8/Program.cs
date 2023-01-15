Console.Clear();
Console.WriteLine("Удаление второго числа в трёхзначном числе.");
Console.Write("Введите трёхзначное число: ");

int number = int.Parse(Console.ReadLine());
int newNumber = 0;

if(number < 100 || number > 999)
{
    Console.WriteLine($"Число {number} не является ТРЁХЗНАЧНЫМ!");
}
else
{
NumberWithoutSecDig();
Console.WriteLine($"Если из числа {number} удалить вторую цифру, получится число {newNumber}.");
}

int NumberWithoutSecDig()
{
    newNumber = number / 100 * 10 + number % 10;
    return newNumber;
}