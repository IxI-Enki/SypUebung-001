namespace CarRace.Logic;

public class Car 
{
  public Car() : this(new DefaultDice())
  {
  }
  public Car(IDice dice)
  {
    _dice = dice;
  }



  #region FIELDS
  private float _speed = 0;
  private int _gear = 0;
  private IDice? _dice;
  #endregion

  #region PROPERTIES
  public float Speed =>_speed;

  public int Gear
  {
    get => _gear;
    set
    {
      int setGear = value;

      if (setGear >= 0 && setGear <= 6)
        _gear = setGear;
      else
        throw new ArgumentException("Gear must be between 0 and 6.");
    }
  }
  #endregion

  #region METHODS
  public void Accelerate() 
  {
    _dice.Roll();
    _speed = Gear * 10 * _dice.Dots;

  }
  #endregion
}