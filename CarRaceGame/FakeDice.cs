using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace.Logic;

public class FakeDice : IDice
{
  public int Dots { get { return 2; } }
  public bool RollWasCalled { get; private set; } = false;
  public void Roll()
  {
    RollWasCalled = true;
  }
}
