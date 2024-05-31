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
        //recurs.CountSubsets(new int[]{1,2,3,4,5},4);
        //recurs.GeneratesBrackets(2);
        recurs.SmartKeypad("1234");
        // int result = recurs.Factorial(6);
        //Console.WriteLine(result);
        //recurs.PrintPermutations();
        // var ans = recurs.FindAllSubsets();
        // foreach (List<int> data in ans)
        // {
        //     Console.Write($"[");
        //     foreach (int i in data)
        //     {
        //         Console.Write($"{i},");
        //     }
        //     Console.Write($"]");
        //     Console.WriteLine();
        // }
        //
        // Console.WriteLine("end....");

        //var nqueen = new NQueenProblem();
        //nqueen.nQueen();
        //var backtrack = new BacktrackingProblem();
        //backtrack.ClimbStairs();
        //backtrack.MazePath();
        //backtrack.SolveSudoko();
        // var ans = backtrack.Subsets();
        //
        // foreach (var an in ans)
        // {
        //     Console.Write("{");
        //     foreach (var i in an)
        //     {
        //         Console.Write(i+",");
        //     }
        //
        //     Console.Write("}");
        //     
        // }
        // Console.WriteLine("----------");
        //backtrack.NQueen();
        //var randomPr = new RandomProblems();
        //randomPr.subsets();

        //backtrack.ClimbStairs();

        // var result = backtrack.Permutations([1, 2, 3, 4]);
        // foreach (List<int> list in result)
        // {
        //     foreach (int i in list)
        //     {
        //         Console.Write(i+",");
        //     }
        //
        //     Console.WriteLine();
        // }

        // var revisionAndPractice = new RivisionAndPractice();
        // var result = revisionAndPractice.Subsets(new[] { 1, 2, 3 });
        // foreach (List<int> list in result)
        // {
        //     foreach (int i in list)
        //     {
        //         Console.Write(i+",");
        //     }
        //     Console.WriteLine();
        // }

    }
}
