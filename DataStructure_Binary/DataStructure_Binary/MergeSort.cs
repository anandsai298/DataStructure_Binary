using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Binary
{
    public class MergeSort
    {
        public void ReadFile(string FilePath)
        {
            string readdata = File.ReadAllText(FilePath);
            string[] words = readdata.Split(" ");
            int[] arr = new int[words.Length];
            int count = 0;
            List<string> list = new List<string>();
            Console.WriteLine("before merge sorting :");
            foreach (var data in words)
            {
                arr[count] = Convert.ToInt32(data);
                count++;
                Console.WriteLine(data);
            }
            if (list.Count > 1)
            {
                int half = list.Count / 2;
                List<string> left = list.GetRange(0, half);
                List<string> right = list.GetRange(half, list.Count - half);

                Console.WriteLine(left);
                Console.WriteLine(right);

                int i = 0, j = 0, k = 0;
                while (i < left.Count && j < right.Count)
                {
                    if (left[i].CompareTo(right[j]) < 0)
                    {
                        list[k] = left[i];
                        i++;
                    }
                    else
                    {
                        list[k] = right[j];
                        j++;
                    }
                    k++;
                }

                while (i < left.Count)
                {
                    list[k] = left[i];
                    i++;
                    k++;
                }

                while (j < right.Count)
                {
                    list[k] = right[j];
                    j++;
                    k++;
                }
            }
        }
    }
}
