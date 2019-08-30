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
    Validation userValidation = new Validation();
    //constructor
    public Human()
    {

    }

    //member methods
    public override void ChooseGesture(List<string> gestureList)
    {
      userValidation.ReadLineFor("What's your weapon of choice?", userValidation.LetterInput);
      string userInput = userValidation.userInput.ToLower();
      if (gestureList.Contains(userInput))
      {
        gesture = userInput;
        Console.Clear();
        return;
      }
      Console.WriteLine("Sorry, that was not a valid choice. Check your typing and try again.");
      ChooseGesture(gestureList);
    }

    public override void SetName()
    {
      userValidation.ReadLineFor("Please enter the player's name:", userValidation.AlphanumericInput);
      name = userValidation.userInput;
    }
  }
}
