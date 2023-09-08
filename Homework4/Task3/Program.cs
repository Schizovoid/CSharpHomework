void FillArray(int[] arr){
    Random random = new Random();

    for (int i = 0; i < arr.Length; i++){
        arr[i] = random.Next(1, 10);
    }
}
void PrintArray (int[] arr){
    for (int i = 0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);