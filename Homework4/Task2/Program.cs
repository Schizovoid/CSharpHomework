Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
int[] arr = getArray(number);

for(int i = 0; i < arr.Length; i++) {
    result = result + arr[i];
}


Console.WriteLine(Convert.ToString(result));

int[] getArray(int num) {
    List<int> list = new List<int>();
    while (num > 0) {
        list.Add(num % 10);
        num = num / 10;
    }
    list.Reverse();
    return list.ToArray();
};
