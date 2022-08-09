class Program
{
    public static void plusMinusSolution(List<int> arr)
    {
        var elements = arr.Count;
        int positives = 0, negatives = 0, zeros = 0;

        foreach (int i in arr)
        {
            if (i > 0) ++positives;
            else if (i < 0) ++negatives;
            else ++zeros;
        }

        double numOfPositives, numOfNegatives, numOfZeros;
        numOfPositives = (double) positives / elements;
        numOfNegatives = (double) negatives / elements;
        numOfZeros = (double) zeros / elements;

        Console.WriteLine(numOfPositives.ToString("0.000000"));
        Console.WriteLine(numOfNegatives.ToString("0.000000"));
        Console.WriteLine(numOfZeros.ToString("0.000000"));
    }

    public static void minMaxSumSolution(List<int> arr)
    {
        arr.Sort();
        int minSum = 0, maxSum = 0;
        foreach (var item in arr)
        {
            minSum += item;
        }

        maxSum = minSum - arr[0];
        minSum -= arr[arr.Count - 1];

        Console.WriteLine(minSum + " " + maxSum);
    }

    public static string timeConvcersionSolution(string input)
    {
        string hours = input.Substring(0, 2);
        string rest = input.Substring(2, 6);
        string format = input.Substring(8);

        if (format.StartsWith("P") && !hours.Equals("12")) hours = (Int16.Parse(hours) + 12).ToString();
        else if (format.StartsWith("A") && hours.Equals("12")) hours = "00";
        return String.Concat(hours, rest);        
    }

    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<int> result = new List<int>();
        Dictionary<string, int> map = new Dictionary<string, int>();

        foreach (string s in strings)
        {
            if (map.ContainsKey(s)) ++map[s];
            else map.Add(s, 1);
        }

        foreach (string q in queries)
        {
            if (map.ContainsKey(q)) result.Add(map[q]);
            else result.Add(0);
        }

        return result;
    }

    public static int lonelyInteger(List<int> a)
    {
        int result = 0;

        foreach (int i in a)
        {
            result ^= i;
        }

        return result;
    }

    public static void Main(string[] args)
    {
        List<int> plusMinusArr = new List<int> { 1, 1, 0, -1, -1 };
        plusMinusSolution(plusMinusArr);

        List<int> minMaxSumArr = new List<int> { 9, 7, 1, 3, 5 };
        minMaxSumSolution(minMaxSumArr);

        string s = "07:05:45PM";
        Console.WriteLine(timeConvcersionSolution(s));

        List<string> strings  = new List<string> { "ab", "ab", "abc" };
        List<string> queries  = new List<string> { "ab", "abc", "bc" };
        List<string> strings1 = new List<string> { "aba", "baba", "aba", "xzxb" };
        List<string> queries1 = new List<string> { "aba", "xzxb", "ab" };
        List<string> strings2 = new List<string> { "def", "de", "fgh" };
        List<string> queries2 = new List<string> { "de", "lmn", "fgh" };
        List<string> strings3 = new List<string> { "abcde", "sdaklfj", "asdjf", "na", "basdn", "sdaklfj", "asdjf",
                                                    "na", "asdjf", "na", "basdn", "sdaklfj", "asdjf" };
        List<string> queries3 = new List<string> { "abcde", "sdaklfj", "asdjf", "na", "basdn" };

        matchingStrings(strings3, queries3);

        lonelyInteger(plusMinusArr);
    }
}