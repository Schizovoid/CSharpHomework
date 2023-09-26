Console.WriteLine("Введите первое натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ack(m,n));

int ack (int m, int n) 
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return ack (m - 1, 1);
    }
    else
    {
        return ack(m - 1, ack(m, n - 1));
    }
}