namespace CarRace.Logic;

public interface IDice
{
  public int Dots { get; }
  public void Roll();
}