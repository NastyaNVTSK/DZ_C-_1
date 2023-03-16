Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 10)
{
    Console.WriteLine((num / 10) % 10);
}
