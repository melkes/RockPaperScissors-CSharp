using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using RockPaper.Models;

namespace RockPaper.Tests
{
  [TestClass]
  public class GameList : IDisposable
  {
    public void Dispose()
    {
      Game.ClearAll();
    }
   
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfItem_Game()
    {
      string player1 = "Rock";
      string player2 = "Paper";
      Game newGame = new Game(player1, player2);
      Assert.AreEqual(typeof(Game), newGame.GetType());
      Assert.AreEqual(player1, newGame.Player1);
      Assert.AreEqual(player2, newGame.Player2);
    }

    [TestMethod]
    public void GetWinner_RockPaper_ReturnPlayer2() {
      string player1Choice = "Rock";
      string player2Choice = "Paper";
      Game newGame = new Game(player1Choice, player2Choice);
      Assert.AreEqual("Player 2", newGame.playGame());
    }
     [TestMethod]
    public void GetWinner_ScissorsRock_ReturnPlayer2() 
    {
      string player1Choice = "Scissors";
      string player2Choice = "Rock";
      Game newGame = new Game(player1Choice, player2Choice);
      Assert.AreEqual("Player 2", newGame.playGame());
    }
    [TestMethod]
    public void GetWinner_PaperScissors_ReturnPlayer2() 
    {
      string player1Choice = "Paper";
      string player2Choice = "Scissors";
      Game newGame = new Game(player1Choice, player2Choice);
      Assert.AreEqual("Player 2", newGame.playGame());
    }

    [TestMethod]
    public void GetWinner_PaperRock_ReturnPlayer1() 
    {
      string player1Choice = "Paper";
      string player2Choice = "Rock";
      Game newGame = new Game(player1Choice, player2Choice);
      Assert.AreEqual("Player 1", newGame.playGame());
    }
    [TestMethod]
    public void GetWinner_RockScissors_ReturnPlayer1() 
    {
      string player1Choice = "Rock";
      string player2Choice = "Scissors";
      Game newGame = new Game(player1Choice, player2Choice);
      Assert.AreEqual("Player 1", newGame.playGame());
    }
    [TestMethod]
    public void GetWinner_ScissorsPaper_ReturnPlayer1() 
    {
      string player1Choice = "Scissors";
      string player2Choice = "Paper";
      Game newGame = new Game(player1Choice, player2Choice);
      Assert.AreEqual("Player 1", newGame.playGame());
    }
    [TestMethod]
    public void GetWinner_PaperPaper_ReturnDraw() 
    {
      string player1Choice = "Paper";
      string player2Choice = "Paper";
      Game newGame = new Game(player1Choice, player2Choice);
      Assert.AreEqual("Draw", newGame.playGame());
    } 

      // Test methods go here
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }
  }
}