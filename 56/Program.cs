// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
//int count = 0;
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
int sum = 0;
int[] result = new int[m];
for (int i = 0; i<m; i++){
    sum = 0;
    for (int j = 0; j < n; j++){
        sum = matrix[i,j] + sum;
        result[i] = sum;            
    }
}
//Console.WriteLine(string.Join(", ", result));    Это суммы строк
int min = result[0];
for(int i = 0; i < result.Length; i++){
    if (result[i] < min){
        min = result[i];
    }
}
Console.WriteLine("Минимальная сумма: " + min);