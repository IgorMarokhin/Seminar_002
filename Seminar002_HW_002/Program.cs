int number;
while (true)
{
    Console.Write("Введите целое число: ");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine("Ошибка ввода!");
}

int num_abs = Math.Abs(number);

if (num_abs < 100)
{
    Console.WriteLine($"Третьей цифры нет");
    return;
}

int ThirdNumberRight = num_abs / 100 % 10;

while(num_abs > 999)
{
    num_abs /= 10;
}
int ThirdNumberLeft = num_abs % 10;

Console.WriteLine($"Третья цифра числа {number} справа -> {ThirdNumberRight}");
Console.WriteLine($"Третья цифра числа {number} слева -> {ThirdNumberLeft}");