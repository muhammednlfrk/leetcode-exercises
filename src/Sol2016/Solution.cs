namespace Sol2016;

public class Solution
{
    public int MaximumDifference(int[] nums)
    {
        int result = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i > j || nums[i] > nums[j]) continue;
                int dif = nums[j] - nums[i];
                if (dif > result && dif != 0) result = dif;
            }
        }

        return result;
    }
}
