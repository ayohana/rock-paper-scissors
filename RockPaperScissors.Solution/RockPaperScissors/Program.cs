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
        Console.WriteLine(NewGame.Player1.Name);
        Console.WriteLine(NewGame.Player2.Name);
        while (!GameOver)
        {
          Console.WriteLine("Enter player 1's sign:");
          string input1 = Console.ReadLine().ToLower();
          Console.WriteLine("Enter player 2's sign:");
          string input2 = Console.ReadLine().ToLower();
          NewGame.AssignSigns(input1, input2);

          Console.WriteLine(NewGame.Player1.Sign);
          Console.WriteLine(NewGame.Player2.Sign);

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
        Console.WriteLine($"{NewGame.Player1.Name} wins");
      }
      else if (result == -1)
      {
        Console.WriteLine($"{NewGame.Player2.Name} wins");
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
    public static void CheckGameOver()
    {
      Rounds++;
      if (Rounds > 3)
      { 
        GameOver = true;
      }
      else
      {
        GameOver = false;
      }
    }
  }
}
