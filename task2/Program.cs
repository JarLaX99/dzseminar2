Console.Write("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 99)
{
    while (numberA > 1000)
    {
        numberA = numberA / 10;
    }
    Console.WriteLine($"{numberA % 10}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}
