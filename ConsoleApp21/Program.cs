Console.WriteLine("Введите x и y");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
try
{
    int z = x / y;

    if (x == 0)
    {
        Console.WriteLine("Ошибка");
    }
    else
    {
        Console.WriteLine(z);
    }

}
catch (DivideByZeroException)
{
    Console.WriteLine("Деление на ноль");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
