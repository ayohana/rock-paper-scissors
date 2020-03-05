using System;

namespace RockPaperScissors.Models
{
  public class Player
  {
    public string Name { get; set; }
    public string Sign { get; set; }
    public int Score { get; set; }

    public Player(string name)
    {
      Name = name;
      Score = 0;
    }
  }
}