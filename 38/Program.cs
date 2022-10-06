// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
int[] array = new int[10];
void InputArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(0, 11);
    }
}
InputArray(array);
System.Console.WriteLine("["+string.Join(", ", array) + "]");
//Кстати, скажите, пожалуйста, какой смысл от добавки System в строке выше? 
//Мы ведь можем делать вывод и без этого
int min = array[0];
int max = array[0];
for (int i = 0; array.Length > i; i++){
    if (array[i] > max){
        max = array[i];
    }
    if (array[i] < min){
        min = array[i];
    }
}
Console.WriteLine($" {max}, {min}");
Console.WriteLine(max - min);