// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4
Console.WriteLine("Введите рамеры массива m*n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] matrix = new int[m,n];
void PrintElement(int[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(-10, 10);
            Console.Write(matrix[i,j] + " ");
            
        }
        Console.WriteLine();
    }
}

PrintElement(matrix);
Console.WriteLine("Введите индексы желаемого элемента в двумерном массиве ");
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
if (i >= m || j >= n){
    Console.WriteLine("Такого элемента нет");
}
else {
    Console.WriteLine(matrix[i,j]);
}
