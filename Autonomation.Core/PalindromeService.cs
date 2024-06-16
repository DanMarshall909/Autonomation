namespace Autonomation.Core;

public static class PalindromeService
{
    public static IEnumerable<string> CommaSeparatedPartitions(string s)
    {
        int len = s.Length;

        // Return an empty list when there's no string to partition
        if (len == 0)
            yield break;

        // Iterate through the string, adding a word to the partition list if the word up to the current index is a palindrome
        for (int end = 0 + 1; end <= len; end++)
        {
            string word = s[..end];
            if (!IsPalindrome(word))
                continue;
            string remainingWord = s[end..];
            // Only add the word if there's nothing left to partition
            if (remainingWord == "")
            {
                yield return word;
            }
            else
            {
                // Recursively partition the remaining word
                // If we have any partitions, add the current word to each of them and add them to the partitions list
                foreach (string remainingPartition in CommaSeparatedPartitions(remainingWord))
                    yield return $"{word},{remainingPartition}";
            }
        }
    }

    public static bool IsPalindrome(string s)
    {
        // A string is not a palindrome if it's empty
        if (s.Length == 0)
            return false;

        // we only need to iterate through half the string because of symmetry
        int sLength = s.Length / 2;
        // iterate through the string, 
        for (var i = 0; i < sLength; i++)
            // compare the first and last characters, the second and second to last, and so on...
            if (s[i] != s[^(i + 1)])
                // if any of the characters don't match, it's not a palindrome
                return false;

        // if we've made it this far, the string must be a palindrome
        return true;
    }
}