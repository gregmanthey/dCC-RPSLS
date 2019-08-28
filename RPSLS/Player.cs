using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
  class Player
  {
    //member variables (has a)
    public int score;
    public string gesture;

    //constructor
    public Player()
    {
      score = 0;
      gesture = "";
    }

    //member methods
    public virtual void ChooseGesture(string gesture = "")
    {
      this.gesture = gesture;
    }
  }
}
