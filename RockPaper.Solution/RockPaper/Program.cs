using System;
using RockPaper.Models;

namespace RockPaper
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Let's play Rock Paper Scissors!");
      Gameplay();
    }

    public static void Gameplay()
    {  
      Console.WriteLine("Enter Player 1 choice: Rock, Paper, or Scissors");
      string player1Choice = Console.ReadLine();
      Console.WriteLine("Enter Player 2 choice: Rock, Paper, or Scissors");
      string player2Choice = Console.ReadLine();
   
      Game newGame = new Game(player1Choice, player2Choice);
      string winner = newGame.playGame();

      if (winner == "Player 1")
      {
        Console.WriteLine("Player 1 wins!");
      }
      else if (winner == "Player 2")
      {
        Console.WriteLine("Player 2 wins!");
      } 
      else if (winner == "Draw")
      {
        Console.WriteLine("It's a draw!");
      }
      Gameplay();

    }
  }

}