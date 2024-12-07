namespace AdventOfCode.Day1;

public class SecondProblem
{
    //Um arquivo com uma lista de 2 colunas aonde deve ser feito uma busca da quantidade de vezes que um valor da primeira coluna aparece na segunda.
    //Então deve ser feito a multiplicacão desse valor pela quantidade de vezes que aparece e somar tudo.
    
    public static int SimilarityList()
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
        

        foreach (var item in firstList)
        {
            var similarityCount = secondList.Count(x => x == item);
            var similarityWeight = item * similarityCount;
            finalValue += similarityWeight;
        }
       
        return finalValue;
    }

}