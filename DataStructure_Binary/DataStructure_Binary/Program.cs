﻿// See https://aka.ms/new-console-template for more information
using System;
namespace DataStructure_Binary;
class program
{
    public static void Main(string[] args)
    {
        bool flag = true;
        while (flag) 
        {
            Console.WriteLine("\n1.BinarySearch\n2.InsertionSort\n3.BubbleSort\n4.Mergesort\n5.Anagram \n6.PrimeNumbers \n7.PrimeNumbers_Anagram_Palindrome\n8.CustomizeString \n9.LinkedListOperation\n10.OrderedList\n11.Simple_Balanced_Parentheses\n12.SimulateBankingCashCounter");
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
                    MergeSort mergeSort = new MergeSort();
                    mergeSort.ReadFile(@"F:\DataStructure_Binary\DataStructure_Binary\DataStructure_Binary\TextFileInteger.txt");
                    break;

                case 5:
                    Anagram anagram = new Anagram();
                    anagram.CheckAnagram();
                    break;

                case 6:
                    PrimeNumbers_Anagram_Palindrome prime = new PrimeNumbers_Anagram_Palindrome();
                    prime.PrimeNumbers(0, 1000);
                    break;

                case 7:
                    break;

                case 8:
                    CustomizeString customizeString = new CustomizeString();
                    customizeString.Customize();
                    break;

                case 9:
                    LinkedListOperation linkedListOperation = new LinkedListOperation();
                    linkedListOperation.ReadFile(@"F:\DataStructure_Binary\DataStructure_Binary\DataStructure_Binary\TextFile1.txt");
                    break;
           
                case 10:
                    OrderedList orderedList = new OrderedList();
                    orderedList.ReadFile(@"F:\DataStructure_Binary\DataStructure_Binary\DataStructure_Binary\TextFileInteger.txt");
                    break;

                case 11:
                    Simple_Balanced_Parentheses simple_Balanced_Parentheses = new Simple_Balanced_Parentheses();
                    simple_Balanced_Parentheses.ReadFile(@"F:\DataStructure_Binary\DataStructure_Binary\DataStructure_Binary\BalancedParanthesis.txt");
                    break;

                case 12:
                    SimulateBankingCashCounter simulateBankingCashCounter = new SimulateBankingCashCounter();
                    simulateBankingCashCounter.BankOperation();
                    break;
            }
        }
    }
}

