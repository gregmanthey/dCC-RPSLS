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
    public string name;

    //constructor
    public Human():base()
    {
      SetName();
    }

    //member methods
    public override void ChooseGesture(string gesture = "")
    {
      Console.WriteLine("Please enter your choice:");
      this.gesture = Console.ReadLine();
    }

    public void SetName()
    {
      Console.WriteLine("Please enter the player's name:");
      name = Console.ReadLine();
    }
  }
}
