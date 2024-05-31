namespace DSALevelUp;

public class RivisionAndPractice
{

    public List<List<int>> Subsets(int[] arr)
    {
        List<List<int>> result = new List<List<int>>();
        Subsets(arr, result, new List<int>(), 0);
        return result;
    }

    private void Subsets(int[] arr, List<List<int>> result, List<int> ans, int count)
    {
        // check base condition

        if (count == arr.Length)
        {
            result.Add(new List<int>(ans));
            return;
        }
        
        ans.Add(arr[count]);
        Subsets(arr, result, ans, count + 1);
        ans.RemoveAt(ans.Count-1);
        Subsets(arr, result, ans, count + 1);
    }
}