// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
int t = 1;
int i = 0;
int j = 0;
while (t <= n * n){
    matrix[i, j] = t;
    t++;
    if (i <= j + 1 && i + j < n - 1)
        j++;
    else if (i < j && i + j >= n - 1)
        i++;
    else if (i >= j && i + j > n - 1)
        j--;
    else
        i--;
}
for (i = 0; i < n; i++){
    for (j = 0; j < n; j++){
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
