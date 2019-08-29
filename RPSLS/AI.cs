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
    
    //constructor
    public AI():base()
    {

    }

    //member methods
    public override void ChooseGesture(List<string> gestures)
    {
      
    }
    public override void SetName()
    {
      List<string> AINames = new List<string> { "Bob", "Sam", "Uma", "Terry", "Max", "Stan", "Judith", "Judas", "Cameron", "Liliana", "Frodo", "Randy", "Beelzeboss", "Tony", "Steve", "Boof" };
      int randomIndex = new Random().Next(0, AINames.Count);
      name = AINames[randomIndex];
      Console.WriteLine("AI's name is: " + name);
    }
  }
}
