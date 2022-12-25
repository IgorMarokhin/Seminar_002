int number;
while (true)
{
    Console.Write("Введите целое трехзначное число: ");
    if (int.TryParse(Console.ReadLine(), out number))
    if (number > 99 && number <= 999)
        break;
    Console.WriteLine("Ошибка ввода!");
}

int num = (number % 100) / 10;

Console.WriteLine($"{number} -> {num}");