using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var set = "abcdefghijklmnopqrstuvwxyz".ToArray();
        input = Regex.Replace(input, "[^a-zA-Z]", "").ToLower();
        foreach (var x in set)
        {
            if (input.Contains(x)) continue;
            return false;
        }
        return true;
    }
}
