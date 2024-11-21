namespace Week3ChallengeLab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2 , 7 , 11 , 15 };
            int target = 18;

            Console.WriteLine($"Find pairs of values in the array that add up to {target}.");

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine($"{nums[i]}, in index {i} plus {nums[j]}, in index {j} {target}");
                    }
                }
            }
        }
    }
}
