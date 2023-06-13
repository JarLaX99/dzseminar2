Console.Write("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 0 && numberA < 6)
{
    Console.WriteLine("Будний день");
}
else if (numberA > 5 && numberA < 8)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("такого дня недели не существует");
}