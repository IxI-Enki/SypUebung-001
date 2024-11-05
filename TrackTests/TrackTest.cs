using CarRace.Logic;
namespace TrackTests;

[TestClass]
public class TrackTest
{
  [TestMethod]
  public void ItShouldReturnTrue_IfTheTrackIsLongerThanZero()
  {
    Track.TrackSegment actualSegment = new(1);

    int expectedSegmentLength = 1;

    Assert.AreEqual(expectedSegmentLength , actualSegment.Length);
  }
}
