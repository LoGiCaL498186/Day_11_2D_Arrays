using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



class Solution
{

    static void Main(String[] args)
    {
        int[][] arr = new int[6][];

        for (int arr_i = 0; arr_i < 6; arr_i++)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
        }

        int top = 0;
        int middle = 0;
        int bottom = 0;   
        int maxSum = -100;
        int tempSum = -100;

        for (int x = 0; x + 2 < arr.Length; x++)
        {
            for (int y = 0; y + 2 < 6 && y + 1 < arr.Length - 1; y++)
            {
                top = arr[x][y] + arr[x][y + 1] + arr[x][y + 2];
                middle = arr[x + 1][y + 1];
                bottom = arr[x + 2][y] + arr[x + 2][y + 1] + arr[x + 2][y + 2];

                tempSum = top + middle + bottom;
                maxSum = (tempSum > maxSum) ? tempSum : maxSum;

                tempSum = -100;

            }
        }
 

        Console.Out.WriteLine(maxSum);

        Console.ReadKey();

    }
}