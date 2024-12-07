namespace AdventOfCode.Day2;

public class SecondProblem
{
    public static int DampenerSafeCodes()
    {
        int lineSafe = 0;

        using (StreamReader streamReader = new StreamReader("/home/juarez/Repos/AdventOfCode/AdventOfCode/Day2/inputDayTwo"))
        {
            while (streamReader.Peek() >= 0)
            {
                string[] pair;

                string line = streamReader.ReadLine();

                pair = line.Split(' ');

                int[] lineNumbers = Array.ConvertAll(pair, int.Parse);

                if (CheckIfSafe(lineNumbers))
                {
                    lineSafe++;
                }
                else
                {
                    for (var i = 0; i < lineNumbers.Length; i++)
                    {
                        var copy = lineNumbers.ToList();
                        copy.RemoveAt(i);
                        if (CheckIfSafe(copy.ToArray()))
                        {
                            lineSafe++;
                            break;
                        }
                    }
                }
            }
        }

        return lineSafe;
    }

    private static bool CheckIfSafe(int[] lineNumbers)
    {
        var d = lineNumbers[1] - lineNumbers[0];

        for (var i = 0; i < lineNumbers.Length - 1; i++)
        {
            var diff = Math.Abs(lineNumbers[i] - lineNumbers[i + 1]);
            var pureDiff = lineNumbers[i] - lineNumbers[i + 1];

            if ((diff == 0) || (pureDiff > 0 && d > 0) || (pureDiff < 0 && d < 0))
            {
                return false;
            }

            if (diff < 1 || diff > 3)
            {
                return false;
            }
        }
        
        return true;
    }
    
    
    // bool dampener = false;
    // var d = lineNumbers[1] - lineNumbers[0];
    //
    //     if (d == 0)
    // {
    //     dampener = true;
    // }
    // else
    // {
    //     for (var i = 0; i < lineNumbers.Length - 1; i++) {
    //         var diff = Math.Abs(lineNumbers[i] - lineNumbers[i + 1]);
    //         var pureDiff = lineNumbers[i] - lineNumbers[i + 1];
    //         
    //         // if ((diff == 0) || (pureDiff > 0 && d > 0) || (pureDiff < 0 && d < 0))
    //         // {
    //         //     dampener = true;
    //         // }
    //
    //         if (diff == 0)
    //         {
    //             dampener = true;
    //         }
    //         
    //         if (diff > 3)
    //         {
    //             dampener = true;
    //         }
    //     }
    // }
    //             
    // lineSafe += dampener ? 0 : 1;
}