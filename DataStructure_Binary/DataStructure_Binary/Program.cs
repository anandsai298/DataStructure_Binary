// See https://aka.ms/new-console-template for more information
using System;
namespace DataStructure_Binary;
class program
{
    public static void Main(string[] args)
    {
        BinarySearch search = new BinarySearch();
        search.ReadFile(@"F:\DataStructure_Binary\DataStructure_Binary\DataStructure_Binary\TextFile1.txt");
        InsertionSort insertionSort = new InsertionSort();
        insertionSort.ReadFile(@"F:\DataStructure_Binary\DataStructure_Binary\DataStructure_Binary\TextFile1.txt");
        BubbleSort bubbleSort = new BubbleSort();
        bubbleSort.ReadFile(@"F:\DataStructure_Binary\DataStructure_Binary\DataStructure_Binary\TextFileInteger.txt");
    }
}

