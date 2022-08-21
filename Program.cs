

class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>() { 7, 3, 100, 200, 300, 350, 400, 401, 402 };
        int k = 3;
        Console.WriteLine(ConsoleTestSolutions.HackerRank.MaxMin.MaxMin.maxMin(k, list));
    }
}