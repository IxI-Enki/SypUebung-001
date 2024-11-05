namespace CarRace.Logic;

public class FakeDice : IDice
{
  #region PROPERTIES
  public int Dots => 2;
  public bool RollWasCalled { get; private set; } = false;
  #endregion

  #region METHODS
  public void Roll() => RollWasCalled = true;
  #endregion
}