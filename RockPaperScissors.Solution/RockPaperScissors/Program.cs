using System;
// using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  public class Program
  {
    public static void Main()
    {
      try
      {
        Console.WriteLine("Enter Player 1's name:");
        string name1 = Console.ReadLine();
        Console.WriteLine("Enter Player 2's name:");
        string name2 = Console.ReadLine();
        Game game = new Game(name1, name2);
        Console.WriteLine(game.Player1.Name);
        Console.WriteLine(game.Player2.Name);

        Console.WriteLine("Enter player 1's sign:");
        string input1 = Console.ReadLine().ToLower();
        Console.WriteLine("Enter player 2's sign:");
        string input2 = Console.ReadLine().ToLower();
        game.AssignSigns(input1, input2);

        Console.WriteLine(game.Player1.Sign);
        Console.WriteLine(game.Player2.Sign);

        int result = game.CheckResult();
        AnnounceWinner(result);
      }
      catch (Exception ex)
      {
        Console.WriteLine("HelpLink = {0}", ex.HelpLink);
        Console.WriteLine("Message = {0}", ex.Message);
        Console.WriteLine("Source = {0}", ex.Source);
        Console.WriteLine("StackTrace = {0}", ex.StackTrace);
        Console.WriteLine("TargetSite = {0}", ex.TargetSite);
      }
    }

    public static void AnnounceWinner(int result)
    {
      if (result == 1)
      {
        Console.WriteLine("Player 1 wins");
      }
      else if (result == -1)
      {
        Console.WriteLine("Player 2 wins");
      }
      else if (result == 0)
      {
        Console.WriteLine("It's a draw!");
      }
      else
      {
        Console.WriteLine("Invalid Input. Please enter again.");
      }
    }
  }
}
