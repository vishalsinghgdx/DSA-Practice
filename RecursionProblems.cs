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

    public void FibonacciSeries()
    {
        
    }
}