using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days.Shared;

internal class InputReader
{
    public static IEnumerable<string> ReadLines(string inputFile)
    {
        using var file = new StreamReader(new FileStream(inputFile, FileMode.Open));

        var line = file.ReadLine();
        while (line != null)
        {
            yield return line;
            line = file.ReadLine();
        }
    }
}
