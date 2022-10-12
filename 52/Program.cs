
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int count = 0;
int[,] matrix = new int[m, n];
void InputMatrix(int[,] matrix){
    for (int i = 0; i<m; i++){
        for (int j = 0; j < n; j++){
            matrix[i,j] = new Random().Next(0, 10);
            Console.Write(matrix[i,j] + " ");
            
        }
        Console.WriteLine();
    }
}
InputMatrix(matrix);
Console.WriteLine();
for (int i = 0; i<n; i++){
    double SrAr = 0;
    count = 0;
    for (int j = 0; j < m; j++){
        SrAr = SrAr + matrix[j,i];
        
        count++;
    }
    Console.WriteLine(Math.Round(SrAr/count, 2));
}