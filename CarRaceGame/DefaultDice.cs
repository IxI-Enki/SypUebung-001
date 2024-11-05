namespace CarRace.Logic;

internal class DefaultDice : IDice
{
  #region FIELDS
  private readonly Random _random = new();
  #endregion

  #region PROPERTRIES
  public int Dots { get; private set; }
  #endregion

  #region METHODS
  public void Roll() => Dots = _random.Next(1 , 7);
  #endregion
}