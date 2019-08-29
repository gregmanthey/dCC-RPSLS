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
    public override void ChooseGesture(string gesture = "")
    {
      Console.WriteLine("Please enter your choice:");
      this.gesture = Console.ReadLine();
    }


  }
}
