Console.Write("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 99 && numberA < 1000)
{
    Console.WriteLine($"{(numberA / 10) % 10}");
}
else
{
    Console.WriteLine(" Ошибка : Введите трёхзначное число");
}