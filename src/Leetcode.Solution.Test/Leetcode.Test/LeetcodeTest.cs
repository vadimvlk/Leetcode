using Leetcode.Solution.Algorithms;
using Xunit;

namespace TestProject;

public class LeetcodeTest
{
    private RomanToInteger? _sut;

    [Theory]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInt_Return_Valid_Integer(string roman, int expected)
    {
        // Arrange
        _sut = new();
        // Act
        int result = _sut.RomanToInt(roman);
        // Assert
        Assert.Equal(expected,result);
    }
}