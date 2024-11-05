namespace CarRace.Logic;

public interface IDice
{
  #region PROPERTIES
  public int Dots { get; }
  #endregion

  #region METHODS
  public void Roll();
  #endregion
}