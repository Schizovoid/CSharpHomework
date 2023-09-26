int max = 0;
int min = 0;
Console.WriteLine("Введите первое натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1) 
{
    Console.WriteLine("Введённое число не является натуральным.");
    return;
}
Console.WriteLine("Введите второе натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m < 1) 
{
    Console.WriteLine("Введённое число не является натуральным.");
    return;
}
 if (n == m) 
 {
    Console.WriteLine("Введённые числа равны.");
    return;
 }
 if (n > m) 
 {
    max = n;
    min = m;
 } else 
 {
    max = m;
    min = n;
 }
int sum = 0;
FindSum(min, max);
Console.WriteLine(sum);

void FindSum (int min, int max){
if (min-1 == max)
{
    return;
}
else
{
sum = sum + min;
FindSum(min+1, max);
}
}