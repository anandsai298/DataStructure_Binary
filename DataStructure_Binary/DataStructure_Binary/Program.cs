// See https://aka.ms/new-console-template for more information
using System;
namespace DataStructure_Binary;
class program
{
    public static void Main(string[] args)
    {
        bool flag = true;
        while (flag) 
        {
            Console.WriteLine("1.BinarySearch\n2.InsertionSort\n3.BubbleSort\n4.Anagram\n5.CustomizeString");
            Console.WriteLine("select option to get output");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    BinarySearch search = new BinarySearch();
                    search.ReadFile(@"F:\DataStructure_Binary\DataStructure_Binary\DataStructure_Binary\TextFile1.txt");
                    break;
                case 2:
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.ReadFile(@"F:\DataStructure_Binary\DataStructure_Binary\DataStructure_Binary\TextFile1.txt");
                    break;
                case 3:
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.ReadFile(@"F:\DataStructure_Binary\DataStructure_Binary\DataStructure_Binary\TextFileInteger.txt");
                    break;
                case 4:
                    Anagram anagram = new Anagram();
                    anagram.CheckAnagram();
                    break;
                case 5:
                    CustomizeString customizeString = new CustomizeString();
                    customizeString.Customize();
                    break;
            }
        }
    }
}

