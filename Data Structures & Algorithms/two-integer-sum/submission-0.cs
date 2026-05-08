public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    int[] result = new int[2];
    var seen = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
      if (seen.TryGetValue(target - nums[i], out int item))
      {
        result[0] = item;
        result[1] = i;
        return result;
      }
      seen.Add(nums[i], i);
    }
    return result;
    }
}
