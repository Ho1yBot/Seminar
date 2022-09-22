int max1 = 0;
int max2 = 0;
int n = Convert.ToInt32(Console.ReadLine());
do {
    n = Convert.ToInt32(Console.ReadLine());
    if (max1 > n){
        max2 = max1;
        max1 = n;
    }
    else if (max2 > n){
        max2 = n;
    }
    
}
while (n != 0);
Console.WriteLine(max1);
if (max1 > max2)
    Console.WriteLine(max1);
else
    Console.WriteLine(max2);
