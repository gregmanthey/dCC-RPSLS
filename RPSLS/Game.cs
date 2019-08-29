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
    public int numberOfHumanPlayers;
    public Player playerOne;
    public Player playerTwo;
    public int numberOfGamesToPlay;

    //constructor
    public Game()
    {
      
    }

    //methods
    //run game
    public void RunGame()
    {
      HowManyPlayers();
      CreatePlayers();
      ShowRules();
      HowManyGames();

      GetGestures();
      DisplayGestureChoices();
      CompareGestures();
      DisplayWinner();

    }
    //set up players-- PvP or PvE
    public void HowManyPlayers()
    {
      Console.WriteLine("How many players? Please press 1 or 2.");
      numberOfHumanPlayers = int.Parse(Console.ReadLine());
      Console.WriteLine($"Sounds great! We will get started with {numberOfHumanPlayers} player(s).");
    }
    public void CreatePlayers()
    {
      playerOne = new Human();
      if (numberOfHumanPlayers == 2)
      {
        playerTwo = new Human();
      }
      else
      {
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
    public void HowManyGames()
    {
      Console.WriteLine("How many games would you like to play? (must be an odd number 3 or higher)");
      numberOfGamesToPlay = int.Parse(Console.ReadLine());
      Console.WriteLine($"Best of {numberOfGamesToPlay} it is!");
    }
    //get gestures from both players
    public void GetGestures()
    {
      int randomNumber = new Random().Next(1, 7);
      Console.WriteLine($"Random number is {randomNumber}");
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
    public void DisplayWinner()
    {
      //Console.WriteLine($"{winner} is the winner!");
    }
  }
}
