using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Binary
{
    public class LinkedListOperation
    {
        public void ReadFile(string FilePath)
        {
            LinkedList<string> list = new LinkedList<string>();
            string readdata = File.ReadAllText(FilePath);
            string[] words = readdata.Split(" ");
            foreach(var data in words)
            {
                list.Add(data);
            }
            string input=Console.ReadLine();
            int result=list.Search(input);
            if(result!=-1)
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
