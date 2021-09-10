public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int[] twoSum = new int[2];
        
        for(int i = 0; i < nums.Length; i++)
        {
            int firstELement = nums[i];
            
            for(int t = i + 1; t < nums.Length; t++)
            {
                int secondElement = nums[t];
                
                int requiredNum = target - firstELement;
                
                if(secondElement == requiredNum)
                {
                    twoSum[0] = i;
                    twoSum[1] = t;
                    
                    return twoSum;
                }
            }            
        }        
        return twoSum;
    }
}