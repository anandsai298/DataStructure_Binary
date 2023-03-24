using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Binary
{
    public class BubbleSort
    {
        public void ReadFile(string FilePath)
        {
            string readdata = File.ReadAllText(FilePath);
            string[] words = readdata.Split(" ");
            int[] arr= new int[words.Length];
            int count = 0;
            Console.WriteLine("before Bubble sorting :");
            foreach (var data in words)
            {
                arr[count]=Convert.ToInt32(data);
                count++;
                Console.WriteLine(data);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > (arr[j]) )
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("After bubble sorting :");
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
