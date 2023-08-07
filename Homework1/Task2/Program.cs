int a = 2;
int b = 4;
int c = 3;
int max = a;

if (max < b) {
    max = b;
}
if (max < c) {
    max = c;
}
Console.WriteLine("Большее число: ");
Console.WriteLine(max);
