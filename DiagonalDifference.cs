//https://www.hackerrank.com/challenges/diagonal-difference
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        int sum = 0;
        int row1 = 0;
        int row2 = 0;
        int num = n;
        
        for(int i = 0; i < n ; i++)
        {
            row1 += a[i][i];
        }
        for(int i = 0; i < n ; i++)
        {
            num--;
            row2 += a[i][num];
        }
        sum = Math.Abs(row1 - row2);
        Console.WriteLine(sum);
    }
}
