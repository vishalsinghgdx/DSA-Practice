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
}