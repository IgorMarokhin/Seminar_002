int number;
while (true)
{
    Console.Write("Введите целое число: ");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine("Ошибка ввода!");
}
if ((number % 7 == 0) && (number % 23 == 0)) Console.WriteLine($"{number} -> да");
else Console.WriteLine($"{number} -> нет");