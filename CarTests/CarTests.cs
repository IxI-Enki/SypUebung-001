using CarRace.Logic;
namespace CarRace.Tests;

[TestClass]
public class CarTests
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
  public void ItShouldReturnZeroSpeed_IfCarHasNotAccelerated()
  {
    Car car = new() { Gear = 3 };

    bool isInValidRange = false;

    if (car.Speed == 0)
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

  [TestMethod]
  public void ItShouldHaveASpeedBetween30And180_GivenGearAndAccelerated()
  {
    Car car = new();

    car.Gear = 3;

    car.Accelerate();

    bool isValidSpeed = car.Speed >= 30 && car.Speed <= 180 ? true : false;

    Assert.IsTrue(isValidSpeed);
  }

  [TestMethod]
  public void ItShouldHaveSpeedOf60_GivenGear3AndDiceShows2()
  {
    Car car = new(gear: 3 , dice: new FakeDice(2));

    car.Accelerate();

    Assert.AreEqual(60 , car.Speed);
  }


}