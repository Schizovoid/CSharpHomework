void fillArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++){
            arr[i,j] = new Random().Next(0, 10);
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
 void calculateArithmeticalMean(int[,] arr){
    int tablesAmount = arr.GetLength(1);

    for (int i = 0; i < arr.GetLength(0); i++){
        double mean = 0;
        for (int j = 0; j < tablesAmount; j++){
            mean = mean + arr[i,j];
        }
        mean = mean / tablesAmount;
        Console.WriteLine(mean);
    }
 }

 int[,] array = new int[4,4];
 fillArray(array);
 printArray(array);
 calculateArithmeticalMean(array);