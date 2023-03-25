using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Binary
{
    public class OrderedList
    {
        public void ReadFile(string FilePath)
        {
            LinkedList<int> list = new LinkedList<int>();
            string readdata = File.ReadAllText(FilePath);
            string[] words = readdata.Split(" ");
            foreach (var data in words)
            {
                int item=Convert.ToInt32(data);
                list.Add(item);
            }
            int input = Convert.ToInt32(Console.ReadLine());
            int result = list.Search(input);
            if (result != -1)
            {
                Console.WriteLine("FOUND");
                list.DeleteNodeAtParticularPosition(result);
            }
            else
            {
                list.Add(input);
            }
            list.Display();
        }
    }
}
