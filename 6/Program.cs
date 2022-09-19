int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[3] { a, b, c};
Console.WriteLine(nums[0]);
for (int i = 0; i < 3; i++){
   
    if (nums[i] % 2 == 0 )
        Console.WriteLine(nums[i] + " - четное");
    else
        Console.WriteLine(nums[i] + " - нечетное");
}