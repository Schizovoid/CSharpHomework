Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1) {
    Console.WriteLine("Введённое число не является натуральным.");
    return;
}
count(n);
void count (int n) {
    if (n == 0) return;
    Console.Write($"{n} ");
    count(n - 1);
}
