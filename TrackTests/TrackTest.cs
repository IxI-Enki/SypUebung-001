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

  [TestMethod]
  public void ItShouldHaveALengthAndAMaxSpeed_GivenObjectCreated()
  {
    var someSpeed = 60;
    var someLength = 400;
    Track.Segment segment = new (someSpeed, someLength);

    Assert.AreEqual(someSpeed, section.MaxSpeed);
    Assert.AreEqual(someLength, section.Length);
  }
}
