int m = new Random().Next(2,5);
int n = new Random().Next(2,5);

double[,] array = new double[m,n];

void fillArray(double[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++){
            arr[i,j] = new Random().Next(-10, 10);
        }
    }
}

void printArray(double[,] arr){
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