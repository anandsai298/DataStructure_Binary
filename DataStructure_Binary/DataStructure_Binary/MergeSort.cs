using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Binary
{
    public class MergeSort
    {
        public static void Merge(List<string> list)
        {
            if (list.Count > 1)
            {
                int half = list.Count / 2;
                List<string> left = list.GetRange(0, half);
                List<string> right = list.GetRange(half, list.Count - half);

                Merge(left);
                Merge(right);

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
