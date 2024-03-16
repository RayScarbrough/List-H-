using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
  
        List<string> playersList = new List<string> { "Chris", "James", "Mark", "Ethan", "Brad" };

       
        playersList.AddRange(new string[] { "Alex", "Luke", "Sam" });

      
        playersList.Sort();
        Console.WriteLine("Sorted List:");
        foreach (string player in playersList)
        {
            Console.WriteLine(player);
        }

      
        playersList.Remove("Luke");

       
        playersList.Reverse();
        Console.WriteLine("\nList in Reverse Order:");
        foreach (string player in playersList)
        {
            Console.WriteLine(player);
        }
    }
}
