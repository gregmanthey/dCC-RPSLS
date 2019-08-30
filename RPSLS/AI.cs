using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
  class AI : Player
  {
    //member variables (has a)
    Random randy = new Random();

    //constructor
    public AI()
    {

    }

    //member methods
    public override void ChooseGesture(List<string> gestures)
    {
      int randomIndex = randy.Next(0, gestures.Count());
      gesture = gestures[randomIndex];
    }
    public override void SetName()
    {
      List<string> AINames = new List<string> { "Bob", "Sam", "Uma", "Terry", "Max", "Stan", "Judith", "Judas", "Cameron", "Liliana", "Frodo", "Randy", "Beelzeboss", "Tony", "Steve", "Boof", "Inky", "Blinky", "Pinky", "Clyde", "Sultans of Swing", "Rage Against the Machine", "Rise Against", "The Who", "Free", "Creed", "Billy Joel", "Steve Miller", "Cleopatra", "Creedence Clearwater Revival", "The Reverend Horton Heat", "Lilith", "Roland", "Burton Reynolds", "Steve Martin", "Todd the T1000", "Someone else", "Ziltoid the Omniscient", "Jablinski", "Not Justin Bieber", "Cthulhu", "The Nameless One", "He who must not be named", "Voldemort", "Herman Miller", "Bill Clinton", "Lebron James", "Peyton Manning", "HAL" };
      int randomIndex = randy.Next(0, AINames.Count());
      name = AINames[randomIndex];
      Console.WriteLine("AI's name is: " + name);
    }
  }
}
