namespace AdventOfCode.Day2;

public class FirstProblem
{
    public static int DiscoverSafeCodes()
    {
        int safe = 0;
        int unSafe = 0;
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
            }
        }
        
        return lineSafe;
    }
    
    private static bool CheckIfSafe(int[] lineNumbers)
    {
        var d = lineNumbers[1] - lineNumbers[0];
        
        for (var i = 0; i < lineNumbers.Length - 1; i++) {
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
            
            // if (pureDiff < 0 && lineNumbers[i] > lineNumbers[i + 1])
            // {
            //     return false;
            // }
            //
            // if (pureDiff > 0 && lineNumbers[i] < lineNumbers[i + 1])
            // {
            //     return false;
            // }
        }
        
        return true;
    }
}