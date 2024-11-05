namespace CarRace.Logic;

public class Car(int gear = 0 , IDice? dice = null)
{
  #region FIELDS
  private float _speed = 0;
  private int _gear = gear;
  private IDice? _dice = dice;
  #endregion

  #region PROPERTIES
  public float Speed { get; set; }

  public void Accelerate()
  {
    Speed = 10 * _gear * _dice!.Dots;
  }

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
}
