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
}