namespace AdventOfCode.Day1;

public class FirstProblem
{
    //Um arquivo com uma lista de 2 colunas aonde cada uma deve ser ordenada de forma crescente e deve ser feita a diferenca entre cada par de valores delas.
    //No final deve ser feita a soma de todas as diferencas.
    
    public static int ResolveList()
    {
        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>();
        int finalValue = 0;
        
        using (StreamReader streamReader = new StreamReader("/home/juarez/Repos/AdventOfCode/AdventOfCode/Day1/inputDayOne"))
        {
            while (streamReader.Peek() >= 0)
            {
                string[] pair;
                
                string line = streamReader.ReadLine();
                
                pair = line.Split(' ');
                
                firstList.Add(int.Parse(pair[0]));
                secondList.Add(int.Parse(pair[3]));
            }
        }
        
        firstList.Sort();
        secondList.Sort();

       for (int i = 0; i < firstList.Count; i++)
       {
           var value = Math.Abs(firstList[i] - secondList[i]);
           finalValue += value;
       }
       
       return finalValue;
    }
    
}