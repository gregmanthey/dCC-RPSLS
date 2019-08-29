﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
  class Game
  {
    //member variables
    public Player playerOne;
    public Player playerTwo;

    //constructor
    public Game()
    {
      
    }

    //methods
    public bool RunGame()
    {
      int numberOfHumanPlayers = HowManyPlayers();
      CreatePlayers(numberOfHumanPlayers);
      ShowRules();
      int numberOfGamesToWin = (HowManyGames() + 1) / 2;
      while(playerOne.score < numberOfGamesToWin && playerTwo.score < numberOfGamesToWin)
      {
        GetGestures();
        DisplayGestureChoices();
        CompareGestures();
        DisplayRoundWinner();
      }
      DisplayGrandWinner();
      return AskToPlayAgain();
    }
    public int HowManyPlayers()
    {
      Console.WriteLine("How many players? Please enter 0, 1, or 2.");
      int numberOfHumanPlayers = int.Parse(Console.ReadLine());
      switch (numberOfHumanPlayers)
      {
        case 0:
        case 1:
        case 2:
          Console.WriteLine($"Sounds great! We will get started with {numberOfHumanPlayers} player(s).");
          return numberOfHumanPlayers;
        default:
          Console.WriteLine($"You entered {numberOfHumanPlayers}, which is not valid.");
          return HowManyPlayers();
      }
    }
    public void CreatePlayers(int numberOfHumanPlayers)
    {
      if (numberOfHumanPlayers == 1)
      {
        playerOne = new Human();
        playerTwo = new AI();
      }
      else if (numberOfHumanPlayers == 2)
      {
        playerOne = new Human();
        playerTwo = new Human();
      }
      else
      {
        playerOne = new AI();
        playerTwo = new AI();
      }
    }
    public void ShowRules()
    {
      Console.WriteLine("Would you like to see the rules?");
      if(Console.ReadLine() == "y")
      {
        //display rules
      }
    }

    public int HowManyGames()
    {
      Console.WriteLine("How many games would you like to play? (best of 3 or higher, must be odd number)");
      int gamesBestOutOf = int.Parse(Console.ReadLine().Trim());
      if (gamesBestOutOf % 2 == 0 || gamesBestOutOf < 3)
      {
        return HowManyGames();
      }
      else
      {
        return gamesBestOutOf;
      }
    }
    public void GetGestures()
    {
      int randomNumber = new Random().Next(1, 6);
      Console.WriteLine($"Random number is {randomNumber}");
      Console.ReadLine();

    }
    public void DisplayGestureChoices()
    {
      Console.WriteLine($"Player one chose {playerOne.gesture} and player two chose {playerTwo.gesture}");
    }
    public void CompareGestures()
    {
      //compare p1.gesture to p2.gesture and find winner
    }
    public void DisplayRoundWinner()
    {
      //Console.WriteLine($"{winner} is the winner!");
    }
    public void DisplayGrandWinner()
    {
      //display overall winner
    }
    public bool AskToPlayAgain()
    {
      Console.WriteLine("Would you like to play again?");
      string toPlayAgain = Console.ReadLine().Trim().ToLower();
      switch (toPlayAgain)
      {
        case "yes":
        case "y":
          return true;
        case "no":
        case "n":
          return false;
        default:
          Console.WriteLine($"You entered {toPlayAgain}. Please enter Yes, Y, No or N.");
          return AskToPlayAgain();
      }

    }
  }
}
