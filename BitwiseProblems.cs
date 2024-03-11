using System;

public class BitwiseProblems
{

    // using bitwise & operator, if multiply the number by 1 results 1 then its odd number other wise its an even number 
    public void CheckEvenOrOdd(int num){
        if((num & 1) == 1)
                Console.WriteLine("Odd");
            else
                Console.WriteLine("Even");
        
    }

    // get ith bit
    public int getIthBit(int n, int i){
        int mask = 1 << i;
        return (n & mask) > 0 ? 1 : 0;
    }

    public void SetIthBit(int n, int i){
        int mask = 1 << i;
        n = n | mask;
        System.Console.WriteLine(n);
    }

    public void ClearIthBit(int n, int i){
        int mask = ~(1 << i);
        n = n & mask;
        System.Console.WriteLine(n);
    }

    public void ClearLastIthBit(int n, int i){
        int mask = (~0 << i);
        n = n & mask;
        System.Console.WriteLine(n);
    }

    public void UpdateIthBit(int n, int i, int v){
        // first clear the bit at ith position
        int mask = ~(1 << i);
        n = n & mask;
        int mask1 = v << i;
        n = n | mask1;
        System.Console.WriteLine(n);
    }

    public void ReplaceIthBit(int m, int n, int i, int j){
        for(int k = i; k <= j; k++){
            int mask = ~(1 << k);
            m = m & mask;
        }
        n = n << i;
        m = m | n;
        System.Console.WriteLine(m);
    }

    public void PowerOfTwo(int N){
        if((N & (N-1)) == 0)
            System.Console.WriteLine($"{N} is power of 2");
            else 
            System.Console.WriteLine($"N is not a power of 2");
    }
}
