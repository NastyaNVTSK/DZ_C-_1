Console.WriteLine("Введите цифру дня недели");
 int day = Convert.ToInt32(Console.ReadLine());
 if (day <1 || day > 7)
 {
    Console.WriteLine("Несуществующий день недели");
 }
 else
 {
    if (day >= 1 & day <= 5)
    {
        Console.WriteLine("Рабочий день");
    }
    else
    {
        Console.WriteLine("выходной день");
    }
 }

