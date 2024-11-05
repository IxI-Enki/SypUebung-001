using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace.Logic;

public class FakeDice(int dotsShown) : IDice
{
  public int Dots { get; set; } = dotsShown;

  public void Roll()
  {
  }
}
