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
    public Human()
    {

    }

    //member methods
    public override void ChooseGesture(List<string> gestureList)
    {
      Console.WriteLine("What's your weapon of choice?");
      string userInput = Console.ReadLine().Trim().ToLower();
      if (gestureList.Contains(userInput))
      {
        gesture = userInput;
        Console.Clear();
        return;
      }
      Console.WriteLine("Sorry, that was not a valid input. Please enter one of the options listed.");
      ChooseGesture(gestureList);
    }

    public override void SetName()
    {
      Console.WriteLine("Please enter the player's name:");
      string userInput = Console.ReadLine().Trim();
      switch (userInput)
      {
        case null:
        case "":
          Console.WriteLine("Please enter a non-blank value for the name.");
          SetName();
          break;
        default:
          name = userInput;
          break;
      }
    }
  }
}
