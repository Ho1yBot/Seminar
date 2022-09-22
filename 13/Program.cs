/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
*/
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99){
    string t = n.ToString();
    Console.WriteLine(t[2]);
}
else{
    //string t = n.ToString();
    Console.WriteLine(n + " --> третьей цифры нет");
}