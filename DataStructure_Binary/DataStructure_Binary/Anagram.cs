using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Binary
{
    public class Anagram
    {
        public void CheckAnagram()
        {
            Console.WriteLine("Enter words to checkAnagram or not");
            string w1=Console.ReadLine();
            string w2=Console.ReadLine();
            if (w1.Length != w2.Length)
                Console.WriteLine("Given words are not Anagram");
            else
            {
                char[] res1 = w1.ToCharArray();
                Array.Sort(res1);
                w1=res1.ToString();
                char[] res2 = w2.ToCharArray();
                Array.Sort(res2);
                w2 = res2.ToString();
                if (w1 == w2)
                {
                    Console.WriteLine("Given words are anagram");
                }
                else
                    Console.WriteLine("not an anagram");
            }
        }
    }
}
