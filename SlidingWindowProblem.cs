using System;
using System.Data;

public class SlidingWindowProblem
{
    public void HousingProblem(){
        int[] plots = {1,3,2,1,4,1,3,2,1,1,2};
        int k = 8;
        //List<int[]> result = new List<int[]>();
        for(int i = 0; i < plots.Length; i++){
            int sum = plots[i];
            for(int j = i+1; j < plots.Length; j++){
                if(sum < k){
                    sum += plots[j];
                }
                if(sum == k){
                    Console.WriteLine(i + " " + j);
                    // int[] val = new int[]{i, j};
                    // result.Add(val);
                     break;
                }
                if(sum > k){
                    break;
                }
            }
        }
    }

    public void HousingProblemTwoPointer(){
         int[] plots = {1,3,2,1,4,1,3,2,1,1,2};
        int k = 8;

        int i = 0;
        int j = 0;
        int sum = plots[i]; // 1
        while(i <= j && j < plots.Length){
            // sum < k
            if(sum < k){
                 j++;
                sum += plots[j];
            }
            else if(sum > k){
                sum -= plots[i];
                i++;
            }else if(sum == k){
                Console.WriteLine(i + " " + j);
                sum -= plots[i];
                i++;
            }
        }
    }

    public void LongestSubstring(string str){
        int Length = str.Length;
        int maxLen = int.MinValue;
        
        
        for(int i = 0; i < Length; i++){
            int count = 0;
            char[] arr = new char[Length];
            for(int j = i; j < Length; j++){
                if(!arr.Contains(str[j])){
                    arr[j] = str[j];
                    count++;
                }
                else{
                    break;
                }
            }
            maxLen = Math.Max(count, maxLen);
        }
        System.Console.WriteLine("max len: " + maxLen);
    }

    public string LongestSubstringOpt(string str)
    {
        // prateek
        int i = 0;
        int j = 0;
        int max_window_len = 0;
        int window_len = 0;
        int start_window = -1;
        Dictionary<char, int> dataSet = new Dictionary<char, int>();
        while(j < str.Length){
            var ch = str[j];
            // if character is inside the window
            if(dataSet.ContainsKey(ch) /*&& dataSet[ch] >= i*/){
                i = dataSet[ch]+1;
                window_len = j-i;
            }

            if(dataSet.ContainsKey(ch))
                dataSet[ch] = j;
            else
                dataSet.Add(ch, j);
            window_len++;
            
            j++;

            if(window_len > max_window_len){
                max_window_len = window_len;
                start_window = i;
            }
        }
        System.Console.WriteLine("i " + i);
        System.Console.WriteLine("window len " + max_window_len);
        return str.Substring(start_window, max_window_len);
    }
}