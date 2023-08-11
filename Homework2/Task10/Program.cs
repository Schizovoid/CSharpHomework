Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(findSecondDigit(number));

int findSecondDigit(int number){
int counter = 0;
int secondDigit = 0;
while (counter < 2){
    int digit = number % 10;
    if(counter == 1) {
        secondDigit = digit;
    }
    number /= 10;
    counter++;
}
return secondDigit;
}


