namespace CarTests;
using CarRaceGame;

[TestClass]
public class CarTest
{
  [TestMethod]
  public void ItShouldReturnZeroSpeed_IfCarIsNew()
  {
    Car car = new();

    float expectedSpeed = 0;
    float actualSpeed = car.Speed;

    Assert.AreEqual(expectedSpeed , actualSpeed);
  }

  [TestMethod]
  public void ItShouldReturnTheGearZero_IfCarIsNew()
  {
    Car car = new();

    int expectedGear = 0;
    int actualGear = car.Gear;

    Assert.AreEqual(expectedGear , actualGear);
  }

  [TestMethod]
  public void ItShouldReturnTheCorrectGear_IfGearIsBetweenOneAndSix()
  {
    Car car = new();

    int expectedGear = 3;
    car.Gear = expectedGear;

    int actualGear = car.Gear;

    Assert.AreEqual(expectedGear , actualGear);
  }

  [TestMethod]
  [ExpectedException(typeof(ArgumentException))]
  public void ItShouldThrowExeption_IfGearIsBetweenOneAndSix()
  {
    Car car = new();

    int expectedGear = 7;

    car.Gear = expectedGear;
  }

  [TestMethod]
  public void ItShouldReturnAValidSpeed_IfSpeedIsBetween30And180()
  {
    Car car = new() { Gear = 3 };

    bool isInValidRange = false;

    if (car.Speed >= 30 && car.Speed <= 180)
      isInValidRange = true;

    Assert.IsTrue(isInValidRange);
  }

  [TestMethod]
  public void ItShouldThrowAnException_GivenSelectedGearIsNegative()
  {
    Car car = new();

    var exception = Assert.ThrowsException<ArgumentException>(() => car.Gear = -1);

    Assert.IsNotNull(exception);
    Assert.AreEqual("Gear must be between 0 and 6." , exception.Message);
  }
} 