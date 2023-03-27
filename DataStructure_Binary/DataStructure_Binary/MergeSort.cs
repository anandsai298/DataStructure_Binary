using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Binary
{
    public class MergeSort
    {
        public void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (int a = 0; a < n1; a++)
                L[a] = arr[l + a];
            for (int b = 0;  b< n2; b++)
                R[b] = arr[m + 1 + b];
            int i = 0, j = 0, k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                Sort(arr, l, m);
                Sort(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }
        public void ReadFile(String filePath)
        {
            String readFile = File.ReadAllText(filePath);
            String[] words = readFile.Split(" ");
            int[] numbers = new int[words.Length];
            int z = 0;
            foreach (String data in words)
            {
                numbers[z] = Convert.ToInt32(data);
                z++;
            }
            Sort(numbers, 0, words.Length - 1);
            foreach (int data in numbers)
            {
                Console.Write(data + " ");
            }
        }
    }
}

