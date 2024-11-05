namespace CarRace.Logic;

public class FakeDice : IDice
{
  public int Dots => 2;

  public bool RollWasCalled { get; private set; } = false;

  public void Roll() => RollWasCalled = true;
}