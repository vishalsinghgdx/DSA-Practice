public class RandomProblems
{
    public void ThreeSum()//(int[] arr, int target)
    {
        int[] ar = {7,-6,3,8,-1,8,-11};//{2,1,-2,2,-1,3,4,5,2};
        int tar = 0;//6;
        // Adding items to dictonary
        // sort the array
        Array.Sort(ar);

        for(int i = 0; i < ar.Length; i++){
            if(i == 0 || ar[i] != ar[i-1]){
            int j = i+1;
            int k = ar.Length-1;
            int complement = tar - ar[i];
            while(j < k){
                int sum = ar[j] + ar[k];
                if(sum == complement){
                    System.Console.WriteLine(ar[i] + " , " + ar[j] + " , "+ ar[k]);
                    // ignore the duplicated

                    j++;
                    k--;
                }else{
                    if(sum < complement)
                        j++;
                    else
                        k--;
                }
            }
            }
          
        }
    }    

    public void RotateMatrix90(){
        int[][] mat = [
            [5,2,3],
            [8,7,4],
            [9,11,5]
        ];
        for(int i = 0; i < mat.Length; i++){
            for(int j = 0; j < mat[0].Length; j++){
                System.Console.Write(mat[i][j] + ",");
            }
            System.Console.WriteLine(" ");
        }

        // make the transpose of matrix
        for(int i = 0; i < mat.Length; i++){
            for(int j = i + 1; j < mat[0].Length; j++){
                var temp = mat[i][j];
                mat[i][j] = mat[j][i];
                mat[j][i] = temp;
            }
        }
        System.Console.WriteLine("After transpose of matrix");
        for(int i = 0; i < mat.Length; i++){
            for(int j = 0; j < mat[0].Length; j++){
                System.Console.Write(mat[i][j] + ",");
            }
            System.Console.WriteLine(" ");
        }
        // spwap the columns
        int left = 0;
        int right = mat[0].Length-1;
        while(left < right){
            for(int i = 0; i < mat.Length; i++){
                var temp = mat[i][left];
                mat[i][left] = mat[i][right];
                mat[i][right] = temp;
            }
            left++;
            right--;
        }

        System.Console.WriteLine("After rotation by 90 of matrix");
        for(int i = 0; i < mat.Length; i++){
            for(int j = 0; j < mat[0].Length; j++){
                System.Console.Write(mat[i][j] + ",");
            }
            System.Console.WriteLine(" ");
        }
    }

    public void SpiralMatrix(){
        int[][] matrix = [
            [1,2,3,4],
            [5,6,7,8],
            [9,10,11,12],
            [13,14,15,16]];
            int rmin = 0;
            int cmin = 0;
            int rmax = matrix.Length-1;
            int cmax = matrix[0].Length-1;
            int count  = 0;
            while(count < matrix.Length * matrix[0].Length){

                // print upper row
                for(int i = cmin; i <= rmax; i++){
                    System.Console.WriteLine(matrix[rmin][i]);
                    count++;
                }
                rmin++;
                
                // print right column
                for(int i = rmin; i <= rmax; i++){
                    System.Console.WriteLine(matrix[i][cmax]);
                    count++;
                }
                cmax--;

                // print bottom row
                for(int i = cmax; i >= cmin; i--){
                    System.Console.WriteLine(matrix[rmax][i]);
                    count++;
                }
                rmax--;

                // print left column
                for(int i = rmax; i >= rmin; i--){
                    System.Console.WriteLine(matrix[i][cmin]);
                    count++;
                }
                cmin++;
            }
    }

    public void FourSum(){
        int[] s = {1,0,-1,0,-2,2};
        Array.Sort(s);
        List<List<int>> result = new List<List<int>>();
        // -2, -1, 0, 0, 1, 2
        int target = 0;
        for(int i = 0; i < s.Length-3; i++){
            if(i > 0 && s[i-1] == s[i]) continue;
            for(int j = i+1; j < s.Length-2; j++){
                if(j > i+1 && s[j-1] == s[j]) continue;
                for(int k = j + 1; k < s.Length-1; k++){
                    if(k > j+1 && s[k-1] == s[k]) continue;
                    for(int l = k + 1; l < s.Length; l++){
                        if(l > k+1 && s[l-1] == s[l]) continue;
                        int sum = s[i]+s[j]+s[k]+s[l];
                        if(sum == target){
                            var li = new List<int>{
                                s[i], s[j], s[k], s[l]
                            };
                            result.Add(li);
                        }
                        if(sum > target)
                            break;
                    }
                }
            }
        }

        System.Console.WriteLine(result);
        System.Console.WriteLine();
    }

    public void FourSumTwoPointer(){
        int[] s = {1,0,-1,0,-2,2};
        Array.Sort(s);
        List<List<int>> result = new List<List<int>>();
        // -2, -1, 0, 0, 1, 2
        int target = 0;
        for(int i = 0; i < s.Length - 3; i++){
            if(i > 0 && s[i-1] == s[i]) continue;
            for(int j = i+1; j < s.Length - 2; j++){
                if(j > i+1 && s[j-1] == s[j]) continue;
                var val = target - (s[i] + s[j]);
                // apply 2 pointer approach here
                int k = j + 1;
                int l = s.Length-1;
                while(k < l){
                    if(s[k] + s[l] == val){
                    var li = new List<int>{
                        s[i],s[j],s[k],s[l]
                    };
                        result.Add(li);
                        k++;l--;
                    }else if(s[k]+s[l] < val){
                        k++;
                    }else{
                        l--;
                    }
                }
              
            }
        }
        System.Console.WriteLine(result);
        System.Console.WriteLine();
    }

    public void SpiralOrderMatrix2(){
        int A = 5;
        int length = A * A;
        int[][] matrix = new int[A][];
        for(int i = 0; i < A; i++){
            matrix[i] = new int[A];
        }

        for(int i = 0; i < matrix.Length; i++){
            for(int j = 0; j < matrix[0].Length; j++){
                System.Console.Write(matrix[i][j] + ",");
            }
            System.Console.WriteLine();
        }
        

        int count = 0;
        int cmin = 0;
        int cmax = A-1;
        int rmin = 0;
        int rmax = A-1;

        // 1 2 3
        // 6 5 4
        // 9 8 7
        
       while(count < length)
       {
            // Upper
            for(int i = cmin; i <= cmax; i++){
                matrix[rmin][i] = count+1;
                count++;
            }
            rmin++;

            // right
            for(int i = rmin; i <= rmax; i++){
                matrix[i][cmax] = count+1;
                count++;
            }
            cmax--;

            // bottom
            for(int i = cmax; i >= cmin; i--){
                matrix[rmax][i] = count+1;
                count++;
            }
            rmax--;

            // left
            for(int i = rmax; i >= rmin; i--){
                matrix[i][cmin] = count+1;
                count++;
            }
            cmin++;
       }

          for(int i = 0; i < matrix.Length; i++){
            for(int j = 0; j < matrix[0].Length; j++){
                System.Console.Write(matrix[i][j] + ",");
            }
            System.Console.WriteLine();
        }
        
    }

    public int BinarySearch(int[] arr, int target, int left, int right)
    {
        while(left <= right){
            var mid = (left + right)/2;
            if(arr[mid] == target)
            {
                return mid;
            } else if(arr[mid] < target){
                left = mid + 1;
            }else{
                right = mid - 1;
            }
        }
        return -1;
    }

    public int[] FirstAndLastPosition(int target)
    {
        int[] arr = {1,1,2,3,5,5,5,5,5,5,7,7,7,7,7,8,8};
        int length = arr.Length;
        int left = 0;
        int right = length-1;
        int first = -1;
        int last = -1;
        while(left <= right)
        {
            var mid = (right + left)/2;
            if(arr[mid] == target){
                first = mid;
                right = mid-1;
            }else if(arr[mid] < target){
                left = mid+1;
            }else{
                right = mid-1;
            }
        }

        if(first == -1) return new int[]{-1,-1};

        left = first+1;
        right = length-1;
        while(left <= right) 
        {
            var mid = (right + left)/2;
            if(arr[mid] == target){
                last = mid;
                left = mid+1;
            }else if(arr[mid] < target){
                left = mid+1;
            }else{
                right = mid-1;
            }
        }

         return new int[]{first , last};
    }

    public int MinimumInSortedAndRotatedArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length-1;
        while(left < right){
            var mid = (right + left)/2;
            if(arr[mid] < arr[right]){
                right = mid;
            }else{
                left = mid+1;
            }
        }
        return left;
    }

    public int SearchInSortedAndRotatedArray(int target){
        int[] arr = {7,8,10,13,14,1,2,4,6};
        // Find min element
        int minIndex = MinimumInSortedAndRotatedArray(arr);
        int left = minIndex;
        int right = arr.Length-1;
        int result  = BinarySearch(arr, target, left, right);
        if(result != -1)
        {
            return result;
        }
        left = 0;
        right = minIndex-1;
        return BinarySearch(arr, target, left, right);

        // while(left <= right){
        //     var mid = (left + right)/2;
        //     if(arr[mid] == target)
        //         return mid;
        //         else if(arr[mid] > target){
        //             right = mid-1;
        //         }else{
        //             left = mid+1;
        //         }
        // } 
        // left = 0;
        // right = minIndex-1;
        // while(left <= right){
        //     var mid = (left + right)/2;
        //     if(arr[mid] == target)
        //         return mid;
        //         else if(arr[mid] > target){
        //             right = mid-1;
        //         }else{
        //             left = mid+1;
        //         }
        // } 
        // return -1;
    }

    public bool SearchInSortedMatrix(int target){
        int[][] arr = [[1,4,6,8,10],
                       [2,7,9,12,15],
                       [3,11,20,22,24],
                       [5,16,25,30,40]];

        int i = 0;
        int j = arr[0].Length-1;
        while(i < arr.Length && j >= 0){
            if(arr[i][j] == target){
                return true;
            }else if(arr[i][j] < target){
                i++;
            }else{
                j--;
            }
        }
        return false;
    }
}