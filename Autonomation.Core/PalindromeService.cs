namespace Autonomation.Core;

public class PalindromeService
{
    public List<string> Generate(string s)
    {
        return [s];
    }

    public static bool IsPalindrome(string s) => !s.Where((t, i) => t != s[^(i + 1)]).Any();
}