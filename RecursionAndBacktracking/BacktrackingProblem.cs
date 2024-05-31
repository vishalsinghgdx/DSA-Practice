using System.Diagnostics;
using System.Text;

namespace DSALevelUp;

public class BacktrackingProblem
{
    /// <summary>
    /// Finding all possible paths
    /// </summary>
    public void FindPath()
    {
        int N = 4;
        int[][] arr = new int[N][];
        for (int i = 0; i < arr.Length; i++)
            arr[i] = new int[N];

        FindPath(arr, 0, 0, new List<string>());
    }

    private void FindPath(int[][] arr, int row, int col,  List<string> res)
    {
        bool canNotTraverse = CannotTraverse(row, col);
        res.Add(row+","+col);
        
        if (IsMatched(row, col))
        {
            foreach (var r in res)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("--------------");
            return;
        }
 
        if (canNotTraverse)
        {
            return;
        }

        if (row == arr.Length || col == arr[0].Length)
        {
            return;
        }
        
        FindPath(arr, row + 1, col, res);
        res.RemoveAt(res.Count-1);
        FindPath(arr, row, col + 1, res);
        res.RemoveAt(res.Count-1);
    }

    private static bool CannotTraverse(int row, int col)
    {
        return (row == 2 && col == 0) || (row == 1 && col == 2);
    }

    private static bool IsMatched(int row, int col)
    {
        return row == 2 && col == 3;
    }
    
    
    //-----------Find all possible subsets

    public List<List<int>> Subsets()
    {
        int[] arr = { 1, 2, 3 };
        List<List<int>> ans = new List<List<int>>();
        List<int> current = new List<int>();
        PossibleSubsets(arr, 0, ans, current);
        return ans;
    }

    private void PossibleSubsets(int[] arr, int counter, List<List<int>> ans, List<int> current)
    {
        if (counter == arr.Length)
        {
            // print answer
            ans.Add(new List<int>(current));
            //PrintSubsetElements(ans);
            return;
        }
        
        current.Add(arr[counter]);
        PossibleSubsets(arr, counter+1, ans, current);
        current.RemoveAt(current.Count-1);
        PossibleSubsets(arr, counter + 1, ans, current);
    }

    private void PrintSubsetElements(List<List<int>> ans)
    {
        foreach (var an in ans)
        {
            Console.Write("{");
            foreach (var i in an)
            {
                Console.Write(i+",");
            }

            Console.Write("}");
            
        }
        Console.WriteLine("----------");
    }

    ////----------------N Queen problem
    public void NQueen()
    {
        int N = 4;
        char[][] arr = new char[N][];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new char[N];
        }

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[0].Length; j++)
            {
                arr[i][j] = '.';
            }
        }
        nQueen(arr, 0);
    }

    private void nQueen(char[][] arr, int row)
    {
        if (row == arr.Length)
        {
            // print here ans
            Print(arr);
            return;
        }

        for (int col = 0; col < arr[0].Length; col++)
        {
            if (IsPlacable(arr, row, col))
            {
                arr[row][col] = 'Q';
                nQueen(arr, row+1);
                // bracktrack fro here
                arr[row][col] = '.';
            }
        }
    }

    private void Print(char[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[0].Length; j++)
            {
                Console.Write(arr[i][j]);
            }
            Console.WriteLine();
        }
        
    }

    private bool IsPlacable(char[][] arr, int row, int col)
    {
        // Check for column
        for (int i = row; i >= 0; i--)
        {
            if (arr[i][col] == 'Q')
                return false;
        }
        
        // Check for diagonal 1
        for (int i = row - 1, j = col + 1; i >= 0 && j < arr[0].Length; i--, j++)
        {
            if (arr[i][j] == 'Q')
                return false;
        }
        // Check for diagnal 2
        for(int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--,j--)
        {
            if (arr[i][j] == 'Q')
                return false;
        }
        return true;
    }
    
    //----------------- Rat in the Maze
    private static List<string> possibleRatPath = new List<string>();
    private static string ans = "";
    public void MazePath()
    {
        char[,] path =
        {
            {'1','0','0','0'},
            {'1','1','0','0'},
            {'1','1','1','0'},
            {'0','0','1','1'}
        };
        FindMazePath(path, 0,0);
        foreach (var re in possibleRatPath)
        {
            Console.Write(re);
            Console.WriteLine("---------");
        }
    }

    private void FindMazePath(char[,] path, int row, int col)
    {
        if (CheckMazePathResult(row, col))
        {
           // passibleRatPath.Add(new List<string>(ans));
           possibleRatPath.Add(ans);
            return;
        }
        if (!IsSafe(path, row, col))
            return;

        ans += "D";
        FindMazePath(path, row + 1, col);
        ans = ans.Substring(0, ans.Length - 1);
        ans += "R";
        FindMazePath(path, row, col + 1);
        ans = ans.Substring(0, ans.Length - 1);
    }

    private bool IsSafe(char[,] path, int row, int col)
    {
        if (row >= 4 || col >= 4 || path[row, col] == '0')
            return false;
        return true;
    }

    private bool CheckMazePathResult(int row, int col)
    {
        if (row == 3 && col == 3)
            return true;
        return false;
    }
    
    
    //------------- Sudoko solver
    public void SolveSudoko()
    {
        for (char c = '1'; c <= '9'; c++)
        {
            //do something with letter 
            Console.WriteLine(c);
        }

        char[][] board =
        [
            ['5', '3', '.', '.', '7', '.', '.', '.', '.'],
            ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
            ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
            ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
            ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
            ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
            ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
            ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
            ['.', '.', '.', '.', '8', '.', '.', '7', '9']
        ];
        Solve(board);
        for (int i = 0; i < board.Length; i++)
        {
            Console.Write("[");
            for (int j = 0; j < board[0].Length; j++)
            {
                Console.Write("'"+board[i][j]+"',");
            }
            Console.Write("]"+",");
            Console.WriteLine();
        }
    }

    bool Solve(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == '.')
                {
                    for (char c = '1'; c <= '9'; c++)
                    {
                        if (IsValidPlace(board, i, j, c))
                        {
                            board[i][j] = c;

                            if (Solve(board) == true)
                            {
                                return true;
                            }

                            board[i][j] = '.';
                        }
                    }

                    return false;
                }
            }
        }
        return true;
    }

    bool IsValidPlace(char[][] board, int row, int col, char val)
    {
        for (int i = 0; i < 9; i++)
        {
            // check col
            if (board[row][i] == val)
                return false;
            // check row
            if (board[i][col] == val)
                return false;
        }
        
        // check 3*3 grid
        int lr = row - row % 3;
        int lc = col - col % 3;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i+lr][j+lc] == val)
                    return false;
            }
        }
        return true;
    }
    
    //----------- Climbing stairs
    public void ClimbStairs()
    {
        int totalSteps = ClimbStairs(4);
        Console.WriteLine(totalSteps);
    }

    private int ClimbStairs(int n)
    {
        if (n == 0)
            return 1;
        if (n < 0)
            return 0;


        n = ClimbStairs(n - 1) + ClimbStairs(n - 2) + ClimbStairs(n-3);

        return n;
    }
    
    // ---------- Find all the permutations
    public List<List<int>> Permutations(int[] arr)
    {
        bool[] status = new bool[arr.Length];
        List<List<int>> ans = new List<List<int>>();
        Permutations(arr, new List<int>(), status, ans);
        return ans;
    }

    public void Permutations(int[] arr, List<int> curr, bool[] status, List<List<int>> ans)
    {
      // base condition
      if (arr.Length == curr.Count)
      {
          ans.Add(new List<int>(curr));
          return;
      }
      for (int i = 0; i < arr.Length; i++)
      {
          if(status[i] == true) continue;
          curr.Add(arr[i]);
          status[i] = true;
          Permutations(arr, curr, status, ans);
          curr.RemoveAt(curr.Count - 1);
          status[i] = false;
      }
    }
    
    // ----- All possible subsets
}