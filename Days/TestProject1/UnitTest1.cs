using System.Text.RegularExpressions;

namespace TestProject1;

public class UnitTest1
{
    [Theory]
    [InlineData("sevenine", "seven", "nine")]
    [InlineData("seven7nine", "seven", "nine")]
    [InlineData("sixsevenine5aa", "six", "5")]
    [InlineData("3456", "3", "6")]
    [InlineData("s45h9j9", "4", "9")]
    public void Test1(string testline, string firstExpected, string lastExpected)
    {
        var regex = new Regex(@"(one|two|three|four|five|six|seven|eight|nine)|(\d)");
        var regexRev = new Regex(@"(one|two|three|four|five|six|seven|eight|nine)|(\d)", RegexOptions.RightToLeft);

        var first = regex!.Match(testline).Value;
        var last = regexRev.Match(testline).Value;

        Assert.Equal(firstExpected, first);
        Assert.Equal(lastExpected, last);
    }
}