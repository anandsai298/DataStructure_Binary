using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Binary
{
    public class BinarySearch
    {
        public void ReadFile(string FilePath)
        {
            string ReadData=File.ReadAllText(FilePath);
            string[] words = ReadData.Split(" ");
            foreach (var data in words)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Enter word to search");
            string search=Console.ReadLine();
            foreach (var data in words)
            {
                if(data==search)
                {
                    Console.WriteLine("match found");
                    return;
                }
            }
            Console.WriteLine("Not found");
        }
    }
}
