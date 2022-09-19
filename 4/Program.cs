int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
int[] nums = new int[3] { a, b, c};
for (int i = 1; i < 3; i++){
   
    if (max < nums[i])
        max = nums[i];
}
Console.WriteLine(max);
