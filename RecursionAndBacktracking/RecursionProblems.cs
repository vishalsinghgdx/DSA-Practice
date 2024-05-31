namespace DSALevelUp;

public class RecursionProblems
{
    public void PrintCounting(int num)
    {
        if(num == 0)
            return;
        PrintCounting(num-1);
        Console.WriteLine(num);
    }

    public void FibonacciSeries(int count)
    {
        // count = 5
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34....
        int a = 0;
        int b = 1;
        Console.Write(a + " ,");
        Console.Write(b + " ,");
        while (count > 2)
        {
            int sum = a + b;
            Console.Write(sum + " ,");
            b = sum;
            a = sum - a;
            count--;
        }
    }

    public void FibonacciSeriesRecursion(int count)
    {
        int a = 0;
        int b = 1;
        Console.Write(a + " ,");
        Console.Write(b + " ,");
        FibonacciSeriesRecursion(count, a, b);
    }

    private void FibonacciSeriesRecursion(int count, int a, int b)
    {
        if(count == 2)
            return;
        int sum = a + b;
        Console.Write(sum + " ,");
        b = sum;
        a = b - a;
        FibonacciSeriesRecursion(count-1, a, b);
    }

    public int Factorial(int num)
    {
        // !6 = 6 * 5 * 4 * 3 * 2 * 1
        if (num == 0)
            return 1;
        return num * Factorial(num - 1);
    }

    public void PrintPermutations()
    {
        // [1,2,3] print all the possible permutations
        int[] arr = { 1, 2, 3, 4 };
        PrintPermutations(arr, 0, new bool[arr.Length], new List<int>());
    }

    private void PrintPermutations(int[] arr, int pos, bool[] selected, List<int> ans)
    {
        if (pos == arr.Length)
        {
            Console.WriteLine(string.Join(", ", ans));
            return;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (selected[i] == false)
            {
                selected[i] = true;
                ans.Add(arr[i]);
                PrintPermutations(arr, pos+1, selected, ans);
                selected[i] = false;
                ans.RemoveAt(ans.Count - 1);
            }
        }
    }

    public List<List<int>> FindAllSubsets()
    {
        int[] arr = { 1, 2, 3 };
        List<List<int>> ans = new List<List<int>>();
        List<int> curr = new List<int>();
        FindAllSubsets(arr, 0, curr, ans);
        
        return ans;
    }

    private void FindAllSubsets(int[] arr, int pos, List<int> curr, List<List<int>> ans)
    {
        if (pos == arr.Length)
        {
            ans.Add(new List<int>(curr));
            return;
        }
        curr.Add(arr[pos]);
        FindAllSubsets(arr, pos + 1, curr, ans);
        curr.RemoveAt(curr.Count - 1);
        FindAllSubsets(arr, pos + 1, curr, ans);
    }

    // Count all the subsets whose target equal to target X
    public void CountSubsets(int[] arr, int X)
    {
        int result = CountSubsets(arr, arr.Length, 0, X);
        Console.WriteLine(result);
    }

    private int CountSubsets(int[] arr, int n, int i, int X)
    {
        // Base case
        if (i == n)
        {
            if (X == 0)
                return 1;
            return 0;
        }
        // Recursive case
        int inc = CountSubsets(arr, n, i + 1, X - arr[i]);
        int exc = CountSubsets(arr, n, i + 1, X);
        return inc + exc;
    } 
    
    // Generates all brackets
    public void GeneratesBrackets(int N)
    {
        string ans = "";
        GeneratesBrackets(N, ans, 0, 0, 0);
    }

    private void GeneratesBrackets(int N, string ans, int count, int openCount, int closeCount)
    {
        // Base case
        if (count == N * 2)
        {
            Console.WriteLine(ans);
            return;
        }
        // Recursion case
        if (openCount < N)
        {
            GeneratesBrackets(N,ans + "(", count + 1, openCount+1, closeCount);
        }
        if (closeCount < openCount)
        {
            GeneratesBrackets(N, ans + ")", count + 1, openCount, closeCount+1);
        }
    }

    public void SmartKeypad(string input)
    {
        // 23
        string[] keys = { "", "", "ABC", "DEF", "GHI","JKL","MNO","PQRS","TUV","WXYZ" };
        string output = "";
        SmartKeypad(keys, input, output, 0);
    }

    private void SmartKeypad(string[] keys, string input, string output, int count)
    {
        // base case
        if (input.Length == count)
        {
            Console.WriteLine(output);
            return;
        }
        
        // recursion case
        int currentIndex = input[count]-'0'; // convert char to int
        if (keys[currentIndex].Length == 0)
        {
            SmartKeypad(keys, input, output, count + 1);
        }
        for (int i = 0; i < keys[currentIndex].Length; i++)
        {
            SmartKeypad(keys, input, output+keys[currentIndex][i], count + 1);
        }
    }
}