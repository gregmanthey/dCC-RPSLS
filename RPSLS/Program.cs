using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
  class Program
  {
    static void Main(string[] args)
    {
      bool keepPlaying;
      do
      {
        Game RPSLS = new Game();
        keepPlaying = RPSLS.RunGame();
      } while (keepPlaying);

      System.Environment.Exit(0);
    }
  }
}
