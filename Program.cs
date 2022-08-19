

class Program
{
    public static void Main(string[] args)
    {
        List<int> arr = new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
        int n = 9;
        Console.WriteLine(
            ConsoleTestSolutions.HackerRank.SockMerchant.SockMerchant.sockMerchant(n, arr)
            );
    }
}