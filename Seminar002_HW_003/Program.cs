int number;
while (true)
{
    Console.Write("Введите целое число от 1 до 7, обозначающее день недели: ");
    if (int.TryParse(Console.ReadLine(), out number))
        if (number >= 1 && number <= 7)
            break;
    Console.WriteLine("Ошибка ввода!");
}
if (number == 6)
    Console.WriteLine($"Введенное число {number}, обозначающее день недели является выходным днем");
else if (number == 7)
    Console.WriteLine($"Введенное число {number}, обозначающее день недели является выходным днем");
else
    Console.WriteLine($"Введенное число {number}, обозначающее день недели не является выходным днем");