using Autonomation.Core;
using FluentAssertions;

namespace Autonomation.Test;

public class PalindromeServiceTests
{
    [Fact(DisplayName = "Generate palindrome partitions of length 1")]
    public void generate_palindrome_partitions_of_length_1()
    {
        var palindromeGenerator = new PalindromeService();

        var result = palindromeGenerator.Generate("a");
        result.Should().BeEquivalentTo(new List<string> { "a" });
    }

    // [Fact(DisplayName = "Generate palindrome of length 2")]
    // public void generate_palindrome_partitions_of_length_2()
    // {
    //     var palindromeGenerator = new PalindromeService();
    //     
    //     var result = palindromeGenerator.Generate("aa");
    //     result.Should().BeEquivalentTo(new List<string>{"aa", "a,a"});
    // }

    [Theory(DisplayName = "Palindromes are detected correctly3")]
    [InlineData("aba")]
    [InlineData("abba")]
    [InlineData("abcba")]
    public void palindromes_are_detected_correctly(string s)
    {
        bool result = PalindromeService.IsPalindrome(s);
        result.Should().BeTrue();
    }

    [Theory(DisplayName = "Non-palindromes are detected correctly3")]
    [InlineData("ab")]
    [InlineData("abac")]
    [InlineData("")]
    public void non_palindromes_are_detected_correctly(string s)
    {
        bool result = PalindromeService.IsPalindrome(s);
        result.Should().BeTrue();
    }
}