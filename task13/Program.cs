Console.WriteLine("Напишиште число");
int number = Convert.ToInt32(Console.ReadLine());

if ( number > 99)
    Console.WriteLine(number.ToString()[2]);
else Console.WriteLine("Третьей цифры нет");