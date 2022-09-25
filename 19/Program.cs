/*
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
//string a = Convert.ToString(Console.ReadLine());
int A = Convert.ToInt32(Console.ReadLine());
int a = A;   //тут у нас преобразуется копия, а не оригинал
int i = 0;
int b = 0;
while (i < 5)
{
    b = b*10;
    b= b + a%10;
    a = a / 10;
    i++;
}
Console.WriteLine("Перевёрнутое число " + b);
if (A == b){
    Console.WriteLine("Yes");
}
else
    Console.WriteLine("No");

//Ниже попытки составить перевёрнутое число способом сложения числа как строки, то есть конкатенацией

//string one = null;
//int i = 0;
// while(i < 6){
//     one = one + a[4-i];
//     i++;
// }
// for (int i = 0; i < 5; i++){
//       string one[i] = a[4-i];
// }
// Console.WriteLine(one);
// if (one == b){
//     Console.WroteLine("Yes");
// }
// else{
//     Console.WriteLine("No");
// }