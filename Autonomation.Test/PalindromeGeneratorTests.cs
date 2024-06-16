using Autonomation.Core;
using FluentAssertions;

namespace Autonomation.Test;

public class PalindromeGeneratorTests
{
    [Fact(DisplayName = "Generate palindrome of length 1")]
    public void generate_palindrome_of_length_1()
    {
        var palindromeGenerator = new PalindromeGenerator();
        
        var result = palindromeGenerator.Generate("a");
        result.Should().BeEquivalentTo(new List<string>{"a"});
    }
}