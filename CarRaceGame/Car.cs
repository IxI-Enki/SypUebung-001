namespace CarRaceGame;

public class Car(int gear = 0)
{
  #region FIELDS
  private float _speed;
  private int _gear = gear;
  #endregion

  #region PROPERTIES
  public float Speed => _gear * 10;

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
