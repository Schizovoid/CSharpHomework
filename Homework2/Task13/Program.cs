Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (findThirdDigit(number) == -1){
    Console.WriteLine("В числе отсутствует третья цифра.");
} else {
    Console.WriteLine(findThirdDigit(number));
}

int findThirdDigit(int number){
int counter = 0;
int ThirdDigit = -1;
while (counter < 3){
    int digit = number % 10;
    if(counter == 0) {
        ThirdDigit = digit;
    }
    if(counter == 2){
        if (number < 1){
            ThirdDigit = -1;
            break;
        }
    }
    number /= 10;
    counter++;
}
return ThirdDigit;
}