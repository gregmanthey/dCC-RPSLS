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
      List<string> AINames = new List<string> { "Bob", "Sam", "Uma", "Terry", "Max", "Stan", "Judith", "Judas", "Cameron", "Liliana", "Frodo", "Randy" };
      Random randy = new Random();
      int randomIndex = randy.Next(0, AINames.Count);
      name = AINames[randomIndex];
    }

    //member methods
    public override void ChooseGesture()
    {
      
    }
    public override void SetName()
    {
      
    }
  }
}
