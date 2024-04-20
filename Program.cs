using System.Runtime.InteropServices;
using DSALevelUp;

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
        //bitwiseProblem.ReplaceIthBit(15, 2, 1, 3);
        //bitwiseProblem.PowerOfTwo(2560);
        //Console.WriteLine(bitwiseProblem.CountSetbitHack(15));
        //Console.WriteLine(bitwiseProblem.CountSetbits(15));

        //var slidingProblm = new SlidingWindowProblem();
        //System.Console.WriteLine(slidingProblm.LongestSubstringOpt("praetaek"));
        //var ramdomPr = new RandomProblems();
        //System.Console.WriteLine(ramdomPr.SearchInSortedMatrix(1));
        var recurs = new RecursionProblems();
        recurs.PrintCounting(100);
    }
}
