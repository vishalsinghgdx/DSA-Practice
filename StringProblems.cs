using System.Net;

public class StringProblems
{
    public void FirstProgram()
    {
        Console.WriteLine("This is first programe");
    }

    public bool CheckSubset(string s1, string s2){
        int i = s1.Length-1;
        int j = s2.Length-1;
        
        while(i >= 0 && j >= 0)
        {
            
            if (s1[i] == s2[j])
            {
                i--;
                j--;
            }
            else
            {
                i--;
            }
        }
        if(j == -1)return true;
        
        return false;
    }
}