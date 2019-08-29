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
    public List<string> gestures = new List<string>{ "rock", "paper", "scissors", "lizard", "spock" };

    //constructor
    public Player()
    {
      SetName();
      score = 0;
      gesture = "";
    }

    //member methods
    public abstract void ChooseGesture();

    public abstract void SetName();

  }
}
