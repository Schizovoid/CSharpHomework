Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (isAHoliday (number) == true) {
    Console.WriteLine("Введённое число - выходной.");
}

if (isAHoliday (number) == false) {
    Console.WriteLine("Введённое число - не выходной.");
}

bool isAHoliday (int num) {
    if (num == 6 || num == 7) {
        return true;
    } else {
        return false;
    }
}