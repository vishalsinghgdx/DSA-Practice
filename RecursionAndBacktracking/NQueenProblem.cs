using System.Diagnostics;

namespace DSALevelUp;

// Given N * N char array. Place N queens such that no 2 queens can attack each other
public class NQueenProblem
{
    public void nQueen()
    {
        int N = 4;
        char[][] arr = new char[N][];
        for (int i = 0; i < arr.Length; i++)
            arr[i] = new char[N];
        for (int i = 0; i < arr.Length; i++)
        for (int j = 0; j < arr[0].Length; j++)
            arr[i][j] = '.';
        nQueen(arr, 0);
    }

    private void nQueen(char[][] arr, int row)
    {
        if (row == arr.Length)
        {
            print(arr);
            return;
        }
        for (int col = 0; col < arr[0].Length; col++)
        {
            if (isSafe(arr, row, col))
            {
                arr[row][col] = 'Q';
                nQueen(arr, row+1);
                arr[row][col] = '.';
            }
        }
    }

    private void print(char[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[0].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }

            Console.WriteLine();
        }
        Console.WriteLine("..........");
    }

    private static bool isSafe(char[][] arr, int row, int col)
    {
        // check for same column
        for (int i = 0; i < row; i++)
        {
            if (arr[i][col] == 'Q')
                return false;
        }
        
        // check diagonal 1
        for (int i = row - 1, j = col + 1; i >= 0 && j < arr[0].Length; i--, j++)
        {
            if (arr[i][j] == 'Q')
                return false;
        }
        // check diagonal 2
        for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
        {
            if (arr[i][j] == 'Q')
                return false;
        }
        return true;
    }
}