// See https://aka.ms/new-console-template for more information

using Days.Shared;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

#region Day 1.1
int CombineFirstAndLastDigits(string line)
{
    List<int> AddIfDigit(List<int> acc, char letter)
    {
        if (char.IsAsciiDigit(letter)) acc.Add(letter - 48);
        return acc;
    }

    var digits = line.Aggregate(new List<int>(), AddIfDigit);
    var d1 = digits.First();
    var d2 = digits.Last();
    return int.Parse($"{d1}{d2}");
}

//var result = InputReader.ReadLines("Input\\day_1_1.txt")
//    .Select(CombineFirstAndLastDigits)
//    .Sum();
//Console.WriteLine("Result: " + result);

#endregion

#region Day 1.2

var regex = new Regex(@"(one|two|three|four|five|six|seven|eight|nine)|(\d)");
var regexRev = new Regex(@"(one|two|three|four|five|six|seven|eight|nine)|(\d)", RegexOptions.RightToLeft);
var numbers = new string[] { "-", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

int CombineFirstAndLastSpelledDigits(string line, int row)
{
    var first = regex!.Match(line).Value;
    var last = regexRev!.Match(line).Value;

    var d1 = int.TryParse(first, out var _d1) ? _d1 : Array.IndexOf(numbers, first);
    var d2 = int.TryParse(last, out var _d2) ? _d2 : Array.IndexOf(numbers, last);

    var ret = int.Parse($"{d1}{d2}");
    Console.WriteLine($"{ret}\t{row}\t{line}");
    return ret;
}

var result = InputReader.ReadLines("Input\\day_1_2.txt")
    .Select(CombineFirstAndLastSpelledDigits)
    .Sum();
Console.WriteLine("Result: " + result);

#endregion
