using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //StringProblems stringProblems = new StringProblems();

        //Console.WriteLine(stringProblems.CheckSubset("coding minutes", "cines"));
        var bitwiseProblem = new BitwiseProblems();
        //bitwiseProblem.CheckEvenOrOdd(50);
        //bitwiseProblem.UpdateIthBit(13, 2, 1);
        //bitwiseProblem.ClearLastIthBit(13, 3);
        bitwiseProblem.ReplaceIthBit(15, 2, 1, 3);
    }
}
