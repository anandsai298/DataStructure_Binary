using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Binary
{
    public class PrimeNumbers_Anagram_Palindrome
    {
        public bool PrimeNumbers(int start,int end)
        {
            Console.WriteLine("prime numbers between"+start+","+end);
            for(int i = start; i <= end;i++)
            {
                if(IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
            return false;
        }
        public static bool IsPrime(int num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

}

