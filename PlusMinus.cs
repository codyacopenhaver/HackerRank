//https://www.hackerrank.com/challenges/plus-minus
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        int pos = 0;
        int neg = 0;
        int zer = 0;
        for(int i = 0; i < n; i++){
         if(arr[i] > 0){
               pos += 1;
         }
            else if(arr[i] < 0){
             neg += 1;
            }
            else if(arr[i] == 0){
             zer += 1;
            }
        }
        float dPos = (float)pos / (float)n;
        float dNeg = (float)neg / (float)n;
        float dZer = (float)zer / (float)n;
        Console.WriteLine(dPos.ToString("N6"));
        Console.WriteLine(dNeg.ToString("N6"));
        Console.WriteLine(dZer.ToString("N6"));
    }
    
}