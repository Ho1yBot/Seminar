// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
int count = 0;
void InputArray(int[] array){
    for(int i = 0; i < M; i++){
        array[i] = new Random().Next(-10, 10);
        if (array[i] > 0) { count++;}
    }
}
InputArray(array);
Console.WriteLine($"[ {string.Join(", ", array)} ]");
Console.WriteLine(count);
