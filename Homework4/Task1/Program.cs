Console.WriteLine("Введите первое число ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int second = Convert.ToInt32(Console.ReadLine());
int result = first;

for (int count = 1; count<second; count++){
    result = result*first;
}
Console.WriteLine(result);