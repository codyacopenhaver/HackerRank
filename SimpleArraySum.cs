/*
Given an array of N integers, can you find the sum of its elements?

Input Format

The first line contains an integer,N, denoting the size of the array. 
The second line contains N space-separated integers representing the array's elements.

Output Format

Print the sum of the array's elements as a single integer.

Sample Input

6
1 2 3 4 10 11
Sample Output

31
Explanation

We print the sum of the array's elements, which is: 1 + 2 + 3 + 4 + 10 + 11 = 31.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine(sum);

    }
}
