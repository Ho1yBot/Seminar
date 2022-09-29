// Задача 27: Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int sum = 0;
int a = Convert.ToInt32(Console.ReadLine());
int def(int a){
    while (a > 0){
        sum = sum + a%10;
        a= a/10;
        //Console.WriteLine(a);
    }
    return sum;
}
int res = def(a);
Console.Write(res);