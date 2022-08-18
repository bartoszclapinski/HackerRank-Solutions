

class Program
{
    public static void Main(string[] args)
    {
        List<List<int>> arr = new List<List<int>> 
        { 
            new List<int>() { 112, 42, 83, 119 },
            new List<int>() { 56, 125, 56, 49 },
            new List<int>() { 15, 78, 101, 43 },
            new List<int>() { 62, 98, 114, 108 }
        };
        Console.WriteLine(ConsoleTestSolutions.HackerRank.FlippingMatrix.FlippingMatrix.flippingMatrix(arr));
        
    }
}