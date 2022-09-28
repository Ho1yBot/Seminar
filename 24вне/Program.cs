/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 --> 28
4 --> 10
8 --> 36
*/
int res = 0;
int a = Convert.ToInt32(Console.ReadLine());
int deio(int a)
{
    //int a = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    for(i=1; i<=a; i++) 
    {
        res = res + i;
        
    }
    return res;
}
int result = deio(a); 
Console.Write(result);