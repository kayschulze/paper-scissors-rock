using System.Collections.Generic;
using System;

namespace PaperScissorsRock.Models
{
    public class PSRClass
    {
      private string _playerOneMove;
      private string _playerTwoMove;
      private string _winner;

      public PSRClass(string playerOneMove, string playerTwoMove)
      {
        _playerOneMove = playerOneMove;
        _playerTwoMove = playerTwoMove;
      }

      public string DetermineWinner()
      {
        return "Nobody ever wins!";
      }

    }
}
