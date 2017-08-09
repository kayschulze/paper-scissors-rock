using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaperScissorsRock.Models;
using System.Collections.Generic;
using System;

namespace PaperScissorsRock.Tests
{
  [TestClass]
  public class PSRClassTest

  {
      [TestMethod]
      public void PSRClass_PaperBeatsRock_Player1()
      {
        //Arrange
        string expectedWinner = "player 1";
        string playerone = "paper";
        string playertwo = "rock";
        PSRClass newGame = new PSRClass(playerone, playertwo);

        //Act
        string actualWinner = newGame.DetermineWinner();

        //Assert
        Assert.AreEqual(expectedWinner, actualWinner);
      }
  }
}
