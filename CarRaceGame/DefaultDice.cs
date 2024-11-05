namespace CarRace.Logic;

internal class DefaultDice : IDice
{
  private readonly Random _random = new();
  
  public int Dots { get; private set; }

  public void Roll() => Dots = _random.Next(1 , 7);
}