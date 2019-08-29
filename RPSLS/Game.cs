using System;
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
    //run game
    public bool RunGame()
    {
      int numberOfHumanPlayers = HowManyPlayers();
      CreatePlayers(numberOfHumanPlayers);
      ShowRules();
      int numberOfGamesToWin = (HowManyGames() + 1) / 2;
      while(playerOne.score < numberOfGamesToWin / 2 && playerTwo.score < numberOfGamesToWin)
      {
        GetGestures();
        DisplayGestureChoices();
        CompareGestures();
        DisplayRoundWinner();
      }
      DisplayGrandWinner();
      return AskToPlayAgain();
    }
    //set up players-- PvP or PvE
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
    //ask if user wants to see the rules
    public void ShowRules()
    {
      Console.WriteLine("Would you like to see the rules?");
      if(Console.ReadLine() == "y")
      {
        //display rules
      }
    }

    //ask how many games to play-- best of 3, 5, 7, etc. up to a certain maximum amount
    public int HowManyGames()
    {
      Console.WriteLine("How many games would you like to play? (must be an odd number 3 or higher)");
      return int.Parse(Console.ReadLine());
    }
    //get gestures from both players
    public void GetGestures()
    {
      int randomNumber = new Random().Next(1, 6);
      Console.WriteLine($"Random number is {randomNumber}");
      Console.ReadLine();

    }
    //display gesture choices
    public void DisplayGestureChoices()
    {
      Console.WriteLine($"Player one chose {playerOne.gesture} and player two chose {playerTwo.gesture}");
    }
    //compare gestures to determine winner
    public void CompareGestures()
    {
      //compare p1.gesture to p2.gesture and find winner
    }
    //display results
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
