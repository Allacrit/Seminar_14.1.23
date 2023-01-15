Console.Clear();
Console.WriteLine("Выяснить кратно ли одно число другому.");

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

int result = 0;

MultipleNumber();

if (result == 0) 
{
    Console.WriteLine($"Число {numberA} кратно числу {numberB}");
}
else
{
    Console.WriteLine($"Число {numberA} не кратно числу {numberB}, остаток от деления равен {result}");
}

int MultipleNumber()
{
    result = numberA % numberB;
    return result;
}