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
      public void PSRClass_PaperBeatsRock_Player2()
      {
        //Arrange
        string expectedWinner = "player 2";
        string playerone = "rock";
        string playertwo = "paper";
        PSRClass newGame = new PSRClass(playerone, playertwo);

        //Act
        string actualWinner = newGame.DetermineWinner();

        //Assert
        Assert.AreEqual(expectedWinner, actualWinner);
      }
  }
}
