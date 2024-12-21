using System.Text.RegularExpressions;

namespace AdventOfCode.Day3;

public class SecondProblem
{
    static Regex mulRegex = new Regex("mul\\([0-9]+,[0-9]+\\)", RegexOptions.IgnoreCase);
    static Regex numberRegex = new Regex("[0-9]+", RegexOptions.IgnoreCase);
    static Regex dontRegex = new Regex("don't\\(\\)", RegexOptions.IgnoreCase);
    static Regex doRegex = new Regex("do\\(\\)", RegexOptions.IgnoreCase);

    static int total = 0;
    static bool IsEnabled = true;
    
    public static int CalculateMullWithPermission()
    {
        using (StreamReader streamReader = new StreamReader("/home/juarez/Repos/AdventOfCode/AdventOfCode/Day3/inputDayThree"))
        {
            while (streamReader.Peek() >= 0)
            {
                string line = streamReader.ReadLine();
                
                var matches = mulRegex.Matches(line);
                
                var doMatches = doRegex.Matches(line);
                var dontMatches = dontRegex.Matches(line);
                
                var doIndicies = doMatches.Select(m => m.Index).ToList();
                var dontIndicies = dontMatches.Select(m => m.Index).ToList();

                var mergedIndicies = doIndicies.Concat(dontIndicies).OrderBy(i => i).ToArray();
                var nextIndex = 0;
                
                foreach (Match match in matches)
                {
                    var matchIndex = match.Index;
                    if (nextIndex < mergedIndicies.Length && matchIndex > mergedIndicies[nextIndex])
                    {
                        var isDo = doIndicies.Contains(mergedIndicies[nextIndex]);
                        IsEnabled = isDo;
                        nextIndex++;
                    }

                    if (IsEnabled)
                    {
                        if (numberRegex.IsMatch(match.ToString()))
                        {
                            MatchCollection numberMatches = numberRegex.Matches(match.ToString());
        
                            var multiply = int.Parse(numberMatches[0].ToString()) * int.Parse(numberMatches[1].ToString());
                            total += multiply;
                        }
                    }
                }
                
            }
        }
        return total;
    }
}