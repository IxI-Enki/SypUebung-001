namespace TrackTests;
using CarRaceGame;

[TestClass]
public class TrackTest
{
  [TestMethod]
  [ExpectedException(typeof(ArgumentException))]
  public void ItShouldThrowExeption_IfTheTrackHasZeroLength()
    => _ = new Track.TrackSegment() { Length = 0 };

  [TestMethod]
  public void ItShouldReturnTrue_IfTheTrackIsLongerThanZero()
  {
    Track.TrackSegment actualSegment = new(1);

    int expectedSegmentLength = 1;

    Assert.AreEqual(expectedSegmentLength , actualSegment.Length);
  }
}