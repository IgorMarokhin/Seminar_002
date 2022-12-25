int ReadNum()
{
    int ResNum;
    while (true)
    {
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out ResNum))
            break;
        Console.WriteLine("Ошибка ввода!");
    }
    return ResNum;
}
int FirstNumber = ReadNum();
int SecondNumber = ReadNum();

int ost = FirstNumber % SecondNumber;

if (ost == 0) Console.WriteLine($"{FirstNumber}, {SecondNumber} -> кратно");
else Console.WriteLine($"{FirstNumber}, {SecondNumber} -> не кратно, остаток {ost}");