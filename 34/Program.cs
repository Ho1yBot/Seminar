// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int n = 10;
int[] array = new int[n];
void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(100, 1000);
}
Console.WriteLine("[" + string.Join(",", array) + "]");
}
InputArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++){
    if (array[i] % 2 == 0) {
        count++;
    } 
}
Console.WriteLine(count);