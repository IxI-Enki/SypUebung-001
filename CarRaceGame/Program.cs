using System.Threading.Channels;

namespace CarRace.Logic;

internal class Program
{
  static void Main() => RunGame();

  private static void RunGame()
  {
    /*
    Section newTrack = GenerateTrack();
    int counter = 1;
    foreach (Section.TrackSegment segment in newTrack.Segments!)
    {
      Console.WriteLine(
        $"Segment Number {counter++} of the track, is {segment.Length}km long\n" +
        $"and has a curvature of {segment.Curvature} degrees");
    }
    */
  }

  /*
    private static Section GenerateTrack()
    {
      Section raceTrack = new();
    
      Section.TrackSegment segmentOne = new(3);
      Section.TrackSegment segmentTwo = new(6);
    
      raceTrack.Segments!.Add(segmentOne);
      raceTrack.Segments!.Add(segmentTwo);
    
      return raceTrack;
    }
  */
}