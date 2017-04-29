//https://www.hackerrank.com/challenges/mini-max-sum
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        Array.Sort(arr);
        long f = 0;
        long b = 0;
        for(int i = 1; i < arr.Length;i++)
        {
            b += arr[i];
        }
        Array.Reverse(arr);
        for(int i = 1; i < arr.Length;i++)
        {
            f += arr[i];
        }
        Console.WriteLine(f + " " + b);
    }
}