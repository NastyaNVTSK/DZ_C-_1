Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 100)
{
    Console.WriteLine((num / 100) % 10);
}
else
{
    Console.WriteLine("Нет третьей цифры");
}

