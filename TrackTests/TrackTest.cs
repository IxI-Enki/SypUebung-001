using CarRace.Logic;
namespace TrackTests;

[TestClass]
public class SectionTest
{
  [TestMethod]
  public void ItShouldHaveALengthAndAMaxSpeed_GivenObjectCreated()
  {
    var someSpeed = 60;
    var someLength = 400;
    Section section = new(someSpeed , someLength);

    Assert.AreEqual(someSpeed , section.MaxSpeed);
    Assert.AreEqual(someLength , section.Length);
  }
}
