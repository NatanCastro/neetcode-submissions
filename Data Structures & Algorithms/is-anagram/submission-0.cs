public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> s1 = new(),
            s2 = new();

        int length = s.Length;
        for (int i = 0; i < length; i++)
        {
            if (s1.TryGetValue(s[i], out int s1value)) s1[s[i]] = ++s1value; else s1.Add(s[i], 1);
            if (s2.TryGetValue(t[i], out int s2value)) s2[t[i]] = ++s2value; else s2.Add(t[i], 1);
        }

        foreach (var item in s1)
        {
            if (!s2.ContainsKey(item.Key)) return false;
            if (item.Value != s2[item.Key]) return false;
        }
        return true;
    }
}
