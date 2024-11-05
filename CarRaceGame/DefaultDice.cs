using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace.Logic
{
  internal class DefaultDice : IDice
  {
    private Random _random = new();
    public int Dots { get; private set; }

    public void Roll()
    {
      Dots = _random.Next(1 , 7);
    }
  }
}
