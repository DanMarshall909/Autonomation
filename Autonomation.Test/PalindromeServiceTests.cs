using Autonomation.Core;
using FluentAssertions;

namespace Autonomation.Test;

public class PalindromeServiceTests
{
    [Theory(DisplayName = "Palindromes are detected correctly")]
    [InlineData("aba")]
    [InlineData("abba")]
    [InlineData("abcba")]
    public void palindromes_are_detected_correctly(string s)
    {
        bool result = PalindromeService.IsPalindrome(s);
        result.Should().BeTrue();
    }

    [Theory(DisplayName = "Non-palindromes are detected correctly")]
    [InlineData("ab")]
    [InlineData("abac")]
    [InlineData("")]
    public void non_palindromes_are_detected_correctly(string s)
    {
        bool result = PalindromeService.IsPalindrome(s);
        result.Should().BeFalse();
    }

    [Fact(DisplayName = "CommaSeparatedPartitions aa correctly")]
    public void partitions_aa_correctly()
    {
        var result = PalindromeService.CommaSeparatedPartitions("aa").ToList();
        result.Should().Contain(new List<string> { "aa", "a,a" });
    }

    [Fact(DisplayName = "CommaSeparatedPartitions abba correctly")]
    public void partitions_abba_correctly()
    {
        var result = PalindromeService.CommaSeparatedPartitions("abba").ToList();
        result.Should().Contain(new List<string> { "abba", "a,bb,a", "a,b,b,a" });
    }

    [Fact(DisplayName = "CommaSeparatedPartitions abbac correctly")]
    public void partitions_abbac_correctly()
    {
        var result = PalindromeService.CommaSeparatedPartitions("abbac").ToList();
        result.Should().Contain(new List<string> { "abba,c", "a,bb,a,c", "a,b,b,a,c" });
    }

    [Fact(DisplayName = "CommaSeparatedPartitions geeks correctly")]
    public void partitions_geeks_correctly()
    {
        var result = PalindromeService.CommaSeparatedPartitions("geeks").ToList();
        result.Should().Contain(new List<string> { "g,e,e,k,s", "g,ee,k,s" });
    }
}