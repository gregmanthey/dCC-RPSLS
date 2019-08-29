using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RPSLS
{
  class Game
  {
    //member variables
    public Player playerOne;
    public Player playerTwo;
    public List<string> gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };


    //constructor
    public Game()
    {
      
    }

    //methods
    public bool RunGame()
    {
      int numberOfHumanPlayers = HowManyPlayers();
      CreatePlayers(numberOfHumanPlayers);
      AskToDisplayRules();
      int numberOfGamesToWin = (HowManyGames() + 1) / 2;
      while(playerOne.score < numberOfGamesToWin && playerTwo.score < numberOfGamesToWin)
      {
        GetGestures();
        DisplayGestureChoices();
        CompareGestures();
        DisplayScore();
      }
      DetermineGrandWinner();
      DisplayScore();
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
        Thread.Sleep(100);
        playerTwo = new AI();
      }
    }
    public void AskToDisplayRules()
    {
      Console.WriteLine("Would you like to see the rules?");
      switch (Console.ReadLine())
      {
        case "yes":
        case "y":
          DisplayRules();
          break;
        case "no":
        case "n":
          Console.WriteLine("Sounds like you already know the ropes. Have fun!");
          return;
        default:
          Console.WriteLine("Please enter Yes, Y, No, or N.");
          AskToDisplayRules();
          break;
      }
    }

    public void DisplayRules()
    {
      string gestureString = "";
      for (int i = 0; i < gestures.Count; i++)
      {
        gestureString += gestures[i][0].ToString().ToUpper();
        gestureString += gestures[i].Substring(1, gestures[i].Length - 1);
        if (i < gestures.Count - 1)
        {
          gestureString += ", ";
        }
      }
      Console.WriteLine($"Rules of {gestureString}:");
      Console.WriteLine("This is a variation of the classic game of Rock, Paper, Scissors.");
      Console.WriteLine("There are two players (in this game, you can play human vs human, human vs computer, or computer vs computer).");
      Console.WriteLine("Each one chooses from the list of options and a winner is determined by these rules:");
      Console.WriteLine($"The options are: {gestureString}.");
      Console.WriteLine("Rock crushes Scissors.");
      Console.WriteLine("Scissors cut Paper.");
      Console.WriteLine("Paper covers Rock.");
      Console.WriteLine("Rock crushes Lizard.");
      Console.WriteLine("Lizard poisons spock.");
      Console.WriteLine("Spock smashes Scissors.");
      Console.WriteLine("Scissors decapitate Lizard.");
      Console.WriteLine("Lizard eats Paper.");
      Console.WriteLine("Paper disproves Spock.");
      Console.WriteLine("Spock vaporizes Rock.");
      Console.WriteLine("If the same value is chosen, it is a tie and must be replayed.");
      Console.WriteLine("Press enter to proceed to play the game:");
      Console.ReadLine();
    }

    public int HowManyGames()
    {
      Console.WriteLine("How many games would you like to play? (best of 3 or higher, must be odd number less than 1,000)");
      int gamesBestOutOf = int.Parse(Console.ReadLine().Trim());
      if (gamesBestOutOf % 2 == 0 || gamesBestOutOf < 3 || gamesBestOutOf > 999)
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
      playerOne.ChooseGesture(gestures);
      playerTwo.ChooseGesture(gestures);

    }
    public void DisplayGestureChoices()
    {
      Console.WriteLine($"{playerOne.name} chose {playerOne.gesture} and {playerTwo.name} chose {playerTwo.gesture}.");
    }
    public void CompareGestures()
    {
      //compare p1.gesture to p2.gesture and find winner
      string g1 = playerOne.gesture;
      string g2 = playerTwo.gesture;
      if (g1 == g2)
      {
        Console.WriteLine("It is a tie! Lettuce try again.");
      }
      else if ((g1 == "rock"     && (g2 == "scissors" || g2 == "lizard")) ||
               (g1 == "paper"    && (g2 == "rock"     || g2 == "spock" )) ||
               (g1 == "scissors" && (g2 == "paper"    || g2 == "lizard")) ||
               (g1 == "lizard"   && (g2 == "spock"    || g2 == "paper" )) ||
               (g1 == "spock"    && (g2 == "scissors" || g2 == "rock"  )))
      {
        //player 1 wins
        playerOne.score++;
        DisplayRoundWinner(playerOne.name);
      }
      else
      {
        //player 2 wins
        playerTwo.score++;
        DisplayRoundWinner(playerTwo.name);
      }
    }
    public void DisplayRoundWinner(string winner)
    {
      Console.WriteLine($"{winner} is the winner of this round vegetable.");
    }

    public void DisplayScore()
    {
      Console.WriteLine("Score:");
      Console.WriteLine($"{playerOne.name}: {playerOne.score}");
      Console.WriteLine($"{playerTwo.name}: {playerTwo.score}");
    }

    public void DetermineGrandWinner()
    {
      if (playerOne.score > playerTwo.score)
      {
        DisplayGrandWinner(playerOne.name);
      }
      else
      {
        DisplayGrandWinner(playerTwo.name);
      }
    }
    public void DisplayGrandWinner(string winner)
    {
      Console.WriteLine($"{winner} has taken all of the marbles!");
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
