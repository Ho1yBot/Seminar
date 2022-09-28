// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
int num = Convert.ToInt32(Console.ReadLine());
int pow = Convert.ToInt32(Console.ReadLine());
Double def(int num, int pow){
    double res = Math.Pow (num, pow);
    return res;
}
double result = def (num, pow);
Console.WriteLine(result);