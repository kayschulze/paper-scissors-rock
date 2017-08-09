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
        if (_playerOneMove == "paper" && _playerTwoMove == "rock")
        {
          _winner = "player 1";
        }
        else if (_playerTwoMove == "paper" && _playerOneMove == "rock")
        {
          _winner = "player 2";
        }

        return _winner;
      }

    }
}
