public class Solution
{
    public string Encode(System.Collections.Generic.IList<string> strs)
    {
        if (strs.Count() == 0) return "-";
        return string.Join("|",
            System.Linq.Enumerable.Select(
                strs,
                str => System.BitConverter.ToString(
                    System.Text.Encoding.ASCII.GetBytes(str)
                ).Replace("-", "")
            )
        );
    }

    public System.Collections.Generic.List<string> Decode(string s)
    {
        Console.WriteLine("out: '{0}'", s);
        if (string.IsNullOrEmpty(s)) return [""];
        if (s == "-") return [];
        return System.Linq.Enumerable.ToList(
            System.Linq.Enumerable.Select(
                s.Split('|'),
                FromHexStringToASCIIString
            )
        );
    }

    private string FromHexStringToASCIIString(string hex)
    {
        int numOfBytes = hex.Length / 2;
        byte[] bytes = new byte[numOfBytes];

        for (int i = 0; i < numOfBytes; i++)
        {
            bytes[i] = System.Convert.ToByte(
                hex.Substring(i * 2, 2),
                16
            );
        }

        return System.Text.Encoding.ASCII.GetString(bytes);
    }
}