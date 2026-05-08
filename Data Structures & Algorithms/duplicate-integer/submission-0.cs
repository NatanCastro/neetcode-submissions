public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seenNumbers = new Dictionary<int, bool>();

        foreach(var num in nums) {
            if (seenNumbers.ContainsKey(num)) {
                return true;
            }
            seenNumbers.Add(num, true);
        }

        return false;
    }
}
