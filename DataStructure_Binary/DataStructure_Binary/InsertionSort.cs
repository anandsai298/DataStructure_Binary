using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Binary
{
    public class InsertionSort
    {
        public void ReadFile(string FilePath)
        {
            string readdata=File.ReadAllText(FilePath);
            string[] words = readdata.Split(" ");
            Console.WriteLine("before Insertion sorting :");
            foreach (var data in words)
            {
                Console.WriteLine(data);
            }
            for (int i = 0; i < words.Length; i++)
            {
                for(int j=i; j < words.Length; j++)
                {
                    if (words[i].CompareTo( words[j])>0)
                    {
                        string temp = words[i];
                        words[i] = words[j];
                        words[j] = temp;
                    }
                }
            }
            Console.WriteLine("After Insertion sorting :");
            foreach (var data in words)
            {
                Console.WriteLine(data);
            }
        }
    }
}
