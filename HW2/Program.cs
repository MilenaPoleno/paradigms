void getMultTable(int num)
{
    for (int i = 1; i <= 9; i++)
    {
        Console.WriteLine($"{num} * {i} = {num * i}");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
getMultTable(number);