public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> itemCount = new();

        foreach (var num in nums)
        {
            if (itemCount.ContainsKey(num))
                itemCount[num]++;
            else
                itemCount.Add(num, 1);
        }

        return itemCount
            .OrderByDescending(i => i.Value)
            .Take(k)
            .Select(i => i.Key)
            .ToArray();
    }
}