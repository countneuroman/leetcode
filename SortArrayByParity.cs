public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        var left = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                (nums[i], nums[left]) = (nums[left], nums[i]);
                left++;
            }
        }
        return nums;        
    }
}