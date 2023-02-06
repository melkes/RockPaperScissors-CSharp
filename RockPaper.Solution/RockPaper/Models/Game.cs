using System.Collections.Generic;
using System;

namespace RockPaper.Models
{
  public class Game
  {
    //Attributes:
    public string Player1 { get; set; }
    public string Player2 { get; set; }
    public Game(string player1Input, string player2Input)
    {
      Player1 = player1Input;
      Player2 = player2Input;
    }
    public string playGame() 
    {
      if (Player1 == "Rock" && Player2 == "Paper") 
      {
        return "Player 2";
      }
      else if (Player1 == "Scissors" && Player2 == "Rock") 
      {
        return "Player 2";
      } 
      else if (Player1 == "Paper" && Player2 == "Scissors") 
      {
        return "Player 2";
      }
      else if (Player1 == Player2)
      {
        return "Draw";
      }
      else 
      {
        return "Player 1";
      }
    }

    public static void ClearAll()
    {
  
    }
  }
}