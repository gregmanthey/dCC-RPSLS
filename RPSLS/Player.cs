using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
  abstract class Player
  {
    //member variables (has a)
    public string name;
    public int score;
    public string gesture;

    //constructor
    public Player()
    {
      SetName();
      score = 0;
      gesture = "";
    }

    //member methods
    public abstract void ChooseGesture(List<string> gestures);

    public abstract void SetName();

  }
}
