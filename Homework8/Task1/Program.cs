int[,] array = new int[4,3];

void fillArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++){
            arr[i,j] = new Random().Next(1, 10);
        }
    }
}

void printArray(int[,] arr){
        for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

fillArray(array);
printArray(array);
