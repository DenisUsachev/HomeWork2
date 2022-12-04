Console.WriteLine("Введите день недели(число)");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
    Console.WriteLine("Сегодня выходной день!");
else Console.WriteLine("Сегодня рабочий день!");