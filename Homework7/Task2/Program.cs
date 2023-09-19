﻿void fillArray(int[,] arr){
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

void findElement(int[,] arr, int table, int line) {
    int searchedElement = arr[table, line];
    bool exists = Array.Exists(arr, element => element == searchedElement);
if (exists) {
    Console.WriteLine(searchedElement);
} else {
    Console.WriteLine("Элемент не найден");
}
}
int[,] array = new int[4,4];
fillArray(array);
printArray(array);
findElement(array, 1,1);
findElement(array, 7,7);
