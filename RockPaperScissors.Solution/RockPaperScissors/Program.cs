using System;
// using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  public class Program
  {
    public static Game NewGame = new Game();
    public static bool GameOver = false;
    public static int Rounds = 1;

    public static void Main()
    {
      try
      {
        Console.WriteLine("Enter Player 1's name:");
        string name1 = Console.ReadLine();
        Console.WriteLine("Enter Player 2's name:");
        string name2 = Console.ReadLine();
        NewGame.AssignNames(name1, name2);

        while (!GameOver)
        {
          Console.WriteLine("Enter player 1's sign:");
          string input1 = Console.ReadLine().ToLower();
          Console.WriteLine("Enter player 2's sign:");
          string input2 = Console.ReadLine().ToLower();
          NewGame.AssignSigns(input1, input2);

          int result = NewGame.CheckResult();
          AnnounceWinner(result);
          CheckGameOver();
        }
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
        Console.WriteLine($"{NewGame.Player1.Sign} vs {NewGame.Player2.Sign} = {NewGame.Player1.Sign} so {NewGame.Player1.Name} wins!");
      }
      else if (result == -1)
      {
        Console.WriteLine($"{NewGame.Player1.Sign} vs {NewGame.Player2.Sign} = {NewGame.Player2.Sign} so {NewGame.Player2.Name} wins!");
      }
      else if (result == 0)
      {
        Console.WriteLine($"{NewGame.Player1.Sign} vs {NewGame.Player2.Sign} = It's a draw!");
      }
      else
      {
        Console.WriteLine("Invalid Input. Please enter again.");
      }
    }

    public static void CheckGameOver()
    {
      Rounds++;
      if (Rounds > 3)
      { 
        GameOver = true;
        Console.WriteLine($"{NewGame.Player1.Name}'s score = {NewGame.Player1.Score}");
        Console.WriteLine($"{NewGame.Player2.Name}'s score = {NewGame.Player2.Score}");
        if (NewGame.Player1.Score > NewGame.Player2.Score)
        {
          Console.WriteLine($"{NewGame.Player1.Name} finally wins!");
        }
        else if (NewGame.Player1.Score < NewGame.Player2.Score)
        {
          Console.WriteLine($"{NewGame.Player2.Name} finally wins!");
        }
        else if (NewGame.Player1.Score == NewGame.Player2.Score)
        {
          Console.WriteLine($"{NewGame.Player1.Name} and {NewGame.Player2.Name} are equal!");
        }
        else
        {
          Console.WriteLine("Invalid Result");
        }

      }
      else
      {
        GameOver = false;
      }
    }
  }
}
