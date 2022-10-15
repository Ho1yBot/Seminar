// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[n, m];
void Matrix1(int[,] matrix1){
    for (int i = 0; i<m; i++){
        for (int j = 0; j < n; j++){
            matrix1[i,j] = new Random().Next(0, 10);
            Console.Write(matrix1[i,j] + " ");
            
        }
        Console.WriteLine();
    }
}
void Matrix2(int[,] matrix2){
    for (int i = 0; i<n; i++){
        for (int j = 0; j < m; j++){
            matrix2[i,j] = new Random().Next(0, 10);
            Console.Write(matrix2[i,j] + " ");
            
        }
        Console.WriteLine();
    }
}
Matrix1(matrix1);
Console.WriteLine();
Matrix2(matrix2);
int[,] result = new int[m, m]; 

for (int i = 0; i<n; i++){
    for (int j = 0; j < m; j++){
        int sum = 0;
        for (int k = 0; k < n; k++)
        {
            sum += matrix1[i,k] * matrix2[k,j];
            
        }
        result[i,j] = sum;   
    }
}
Console.WriteLine();
for (int i = 0; i<n; i++){
    for (int j = 0; j < m; j++){
        Console.Write(result[i,j] + " ");
            
    }
    Console.WriteLine();
}
