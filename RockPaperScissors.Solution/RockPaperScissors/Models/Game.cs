using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public Player Player1 { get; set; }
    public Player Player2 { get; set; }
    public string[] SignsArr { get; set; }

    public Game(string name1, string name2)
    {
      Player1 = new Player(name1);
      Player2 = new Player(name2);
    }

    public void AssignSigns(string input1, string input2)
    {
      Player1.Sign = input1;
      Player2.Sign = input2;
      string joined = input1 + input2;
      SignsArr = new string[] { joined };
    }

    public int CheckResult()
    {
      // 0 for draw
      // 1 for player 1's win
      // -1 for player 1's loss
      // 2 for invalid input
      if (Player1.Sign == Player2.Sign)
      {
        return 0;
      }
      else if (SignsArr.Contains("rockpaper") || SignsArr.Contains("paperscissors") || SignsArr.Contains("scissorsrock"))
      {
        return -1;
      }
      else if (SignsArr.Contains("scissorspaper") || SignsArr.Contains("paperrock") || SignsArr.Contains("rockscissor"))
      {
        return 1;
      }
      else
      {
        return 2;
      }
    }

    
    // public string CheckWinner()
    // {
    //   if (Player1Sign == "rock")
    //   {
    //     if (Player2Sign =="rock")
    //     {
    //       return $"It's a draw!";
    //     }
    //     else if (Player2Sign == "scissors")
    //     {
    //       return $"Player1 wins";
    //     }
    //     else if (Player2Sign == "paper")
    //     {
    //       return $"Player2 wins";
    //     }
    //     else
    //     {
    //       return $"Invalid input. Please try again.";
    //     }
    //   }
    //   else if (Player1Sign == "scissors")
    //   {
    //     if (Player2Sign == "scissors")
    //     {
    //       return $"It's a draw!";
    //     }
    //     else if (Player2Sign == "rock")
    //     {
    //       return $"Player2 wins";
    //     }
    //     else if (Player2Sign == "paper")
    //     {
    //       return $"Player1 wins";
    //     }
    //     else
    //     {
    //       return $"Invalid input. Please try again.";
    //     }
    //   } 
    //   else if (Player1Sign == "paper")
    //   {
    //     if (Player2Sign == "paper")
    //     {
    //       return $"It's a draw!";
    //     }
    //     else if (Player2Sign == "scissors")
    //     {
    //       return $"Player2 wins";
    //     }
    //     else if (Player2Sign == "rock")
    //     {
    //       return $"Player1 wins";
    //     }
    //     else
    //     {
    //       return $"Invalid input. Please try again.";
    //     }
    //   }
    //   else
    //   {
    //     return $"Invalid input. Please try again.";
    //   }
    // }
    
  }
}
