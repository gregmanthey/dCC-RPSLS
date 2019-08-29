using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
  class Human : Player
  {
    //member variables (has a)

    //constructor
    public Human():base()
    {
      SetName();
    }

    //member methods
    public override void ChooseGesture()
    {
      Console.WriteLine("Please enter your choice (Rock, Paper, Scissors, Lizard, Spock):");
      string userInput = Console.ReadLine().Trim().ToLower();
      if (gestures.Contains(userInput))
      {
        gesture = userInput;
        return;
      }
      Console.WriteLine("Sorry, that was not a valid input. Please enter one of the options listed.");
      ChooseGesture();
    }

    public override void SetName()
    {
      Console.WriteLine("Please enter the player's name:");
      name = Console.ReadLine();
    }
  }
}
