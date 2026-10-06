using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        string[] players = { "Alex", "Ben", "Chris", };
        int[,] scores = new int[3, 3];

        Console.WriteLine("  Enter Player Scores  ");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter Scores for " + players[i] + ":");
            Console.Write("Round 1: ");
            scores[i, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Scores for " + players[i] + ":");
            Console.Write("Round 2: ");
            scores[i, 1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Scores for " + players[i] + ":");
            Console.Write("Round 3: ");
            scores[i, 2] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine("Player \t\tRound 1\tRound 2\tRound 3 3\tTotal");
        Console.WriteLine("\n");
        for (int i = 0; i < 3; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];

            Console.WriteLine(players[i] + "\t\t" + scores[i, 0] + "\t" + scores[i, 1] + "\t" + scores[i, 2] + "\t" + total);
        }

    }
    public static void sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
            printArray(arr);
        }
    }
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " | ");
        Console.WriteLine();
    }
}










   