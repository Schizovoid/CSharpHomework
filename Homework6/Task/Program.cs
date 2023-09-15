int[] getNumbersArray (){
    Console.WriteLine("Введите количество элементов");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[length];
    for (int count = 0; count < length; count++) {
        Console.WriteLine("Введите следующий элемент");
        arr[count] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int countPosNumbers(int[] arr){
    int count = 0;
    for(int i = 0; i < arr.Length; i++){
        if (arr[i] > 0) {
            count++;
        }
    }
    return count;
}

int [] array = getNumbersArray();

Console.WriteLine(countPosNumbers(array));
