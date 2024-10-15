namespace CarRaceGame;

public class Track
{
  #region EMBEDED TRACK SEGMENT
  public class TrackSegment(int length = 1 , int? curvature = 0)
  {
    private int _length = length;

    public int Length
    {
      get => _length;
      set
      {
        int setLenght = value;

        if (setLenght > 0)
          _length = setLenght;
        else
          throw new ArgumentException("TrackSegment can't be less than 0");
      }
    }
    public int? Curvature { get; private set; } = curvature;
  }
  #endregion

  public List<TrackSegment>? Segments { get; set; } = new List<TrackSegment>();
}