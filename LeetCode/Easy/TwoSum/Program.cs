int target = 6;
int[] nums = { 3, 2, 4 };
int[] result = new int[2];

int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 1; j < nums.Length; j++)
        {
            if(nums[i] + nums[j] == target)
            {
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

TwoSum(nums, target);
Console.WriteLine("Result: {0} {1}", result[0], result[1]);
Console.ReadLine();