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

    public static long flippingBits(long n)
    {
        uint result = 0;
        uint input = ~(uint)n;        

        return (long) result;
    }

    public static int diagonalDifference(List<List<int>> arr)
    {
        int sum = 0;
        
        for (int i = 0; i < arr.Count; i++)
        {            
            sum += arr[i][i] - arr[i][arr[i].Count - i - 1];            
        }       

        return Math.Abs(sum);
    }

    public static List<int> countingSort(List<int> arr)
    {
        int[] resultArr = new int[100];
        
        foreach (int i in arr)
        {
            resultArr[i] += 1;
        }

        return resultArr.ToList();
    }

    public static string pangrams(string s)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        
        string sortedInput = String.Concat(s
            .ToLower()
            .Where(s => !Char.IsWhiteSpace(s))
            .OrderBy(s => s)
            .Distinct());        
        
        if (sortedInput.Equals(alphabet)) return "pangram";
        else return "not pangram";
    }

    public static string twoArrays(int k, List<int> A, List<int> B)
    {
        var sortedA = A.OrderBy(a => a).ToList();
        var sortedB = B.OrderByDescending(b => b).ToList();

        for (int i = 0; i < A.Count; i++)
        {
            if (sortedA[i] + sortedB[i] < k) return "NO";
        }
        return "YES";
    }

    public static int birthday(List<int> s, int d, int m)
    {
        int result = 0, count = 0;
                
        for (int i = 0; i < s.Count; i++)
        {
            if ((i + m - 1) < s.Count)
            {
                for (int j = i; j < (i + m); j++)
                {
                    result += s[j];
                }

                if (result == d) ++count;

                result = 0;
            }
        }

        return count;
    }

    public static string xorStrings2(string s, string t)
    {
        /*
         *  Solution bugged at HackerRank
         */
        string result = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s.ToCharArray()[i] == t.ToCharArray()[i]) result += 0;
            else result += 1;
        }

        return result;
    }

    public static void showListItems(List<int> arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        List<int> arr = new List<int> { 4, 1 };
        Console.WriteLine(birthday(arr, 4, 1));
    }
}