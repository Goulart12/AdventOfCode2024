using System.Text.RegularExpressions;

namespace AdventOfCode.Day3;

public class FirstProblem
{
    static Regex mulRegex = new Regex("mul\\([0-9]+,[0-9]+\\)", RegexOptions.IgnoreCase);
    static Regex numberRegex = new Regex("[0-9]+", RegexOptions.IgnoreCase);
    static int total = 0;
    static List<string> mullGet = new List<string>();
    public static int CalculateMull()
    {
        using (StreamReader streamReader = new StreamReader("/home/juarez/Repos/AdventOfCode/AdventOfCode/Day3/inputDayThree"))
        {
            while (streamReader.Peek() >= 0)
            {
                string[] mulls;
                
                string line = streamReader.ReadLine();
                
                mulls = line.Split(' ');

                foreach (var item in mulls)
                {
                    if (mulRegex.IsMatch(item))
                    {
                        MatchCollection matches = mulRegex.Matches(item);

                        foreach (var match in matches)
                        {
                            mullGet.Add(match.ToString());
                        }
                    }
                }
            }
        }
        foreach (var mulItem in mullGet)
        {
            if (numberRegex.IsMatch(mulItem))
            {
                MatchCollection numberMatches = numberRegex.Matches(mulItem);
                
                var multiply = int.Parse(numberMatches[0].ToString()) * int.Parse(numberMatches[1].ToString());
                total += multiply;
            }
        }
        return total;
    }
}