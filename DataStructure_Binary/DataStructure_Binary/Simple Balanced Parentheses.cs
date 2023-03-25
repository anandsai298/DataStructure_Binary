using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Binary
{
    public class Simple_Balanced_Parentheses
    {
        public void ReadFile(string FilePath)
        {
            LinkedListStack<string> list = new LinkedListStack<string>();
            string readdata = File.ReadAllText(FilePath);
            string[] words = readdata.Split(" ");
            foreach (var data in words)
            {
                if (data.Equals("("))
                    list.Push(data);
                if (data.Equals(")"))
                    list.Pop();
            }
            list.Peek();
        }
    }
}
