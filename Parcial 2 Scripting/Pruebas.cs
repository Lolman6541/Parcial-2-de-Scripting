using NUnit.Framework;

[TestFixture]
public class BikeTests
{
    [Test]
    public void BikeCanBeCreated()
    {
        Chassis chassis = new Chassis();
        Bike bikeWithChassis = new Bike { Chassis = chassis};
        Assert.NotNull(bikeWithChassis);
        Assert.AreEqual(1.0, bikeWithChassis.Speed);

        Bike bikeWithoutChassis = new Bike();
        Assert.Null(bikeWithoutChassis);
    }

    [Test]
    public void BikesCanBeUsed()
    {
        FrontWheel frontWheel = new FrontWheel();
        BackWheel backWheel = new BackWheel();
        Chassis chassis = new Chassis();
        Engine engine = new Engine();
        Muffler muffler =  new Muffler();

        Bike bike = new Bike 
        {
            Chassis = chassis,
            FrontWheel = frontWheel,
            BackWheel = backWheel,
            Engine = engine,
            Muffler = muffler
        };

        Assert.ItsTrue(bike.Speed > 0);
        Assert.ItsTrue(bike.Acceleration > 0);
        Assert.ItsTrue(bike.Handling > 0);
        Assert.ItsTrue(bike.Grip > 0);
    }

    [Test]
    public void PartCanBeAdded()
    {
        Chassis chassis = new Chassis();
        FrontWheel frontWheel = new FrontWheel();

        Bike bike = new Bike { Chassis = chassis };
        bike.FrontWheel = frontWheel;

        Assert.AreEqual(2.0, bike.Acceleration);
        Assert.AreEqual(2.0, bike.Grip);


        BackWheel backWheel = new BackWheel();
        bike.BackWheel = backWheel;

        Assert.AreEqual(3.0, bike.Acceleration);
        Assert.AreEqual(3.0, bike.Grip);


        Muffler muffler = new Mufller();
        bike.Mufller = muffler;

        Assert.AreEqual(1.5, bike.Acceleration);

    }
    [Test]
    public void PartsModifyParameters()
    {
        Bike.bike = new Bike();

        Assert.AreEqual(1.0, bike.Speed);
        Assert.AreEqual(1.0, bike.Acceleration);
        Assert.AreEqual(1.0, bike.Handling);
        Assert.AreEqual(1.0, bike.Grip);

        Part part = new Engine();
        bike.AddParT(part);

        Assert.AreEqual(1.0, bike.Speed);
        Assert.AreEqual(1.0, bike.Acceleration);
        Assert.AreEqual(1.0, bike.Handling);
        Assert.AreEqual(1.0, bike.Grip);

        bike = new Bike();

        Part frontWheel = new FrontWheel();
        Part backWheel = new BackWheel();
        Part muffler = new Muffler();

        bike.AddPart(frontWheel);
        Assert.AreEqual(2.0, bike.Acceleration);
        Assert.AreEqual(2.0, bike.Grip);

        bike.AddPart(backWheel);
        Assert.AreEqual(3.0, bike.Acceleration);
        Assert.AreEqual(3.0, bike.Grip);

        bike.AddPart(muffler);
        Assert.AreEqual(1.5, bike.Acceleration);
    }

    [Test]
    public void MaxParameterValueOnConstructor()
    {
        Part part = new FrontWheel();

        Assert.AreEqual(0.0, part.ModifySpeed);
        Assert.AreEqual(0.0, part.ModifyAcceleration);
        Assert.AreEqual(0.0, part.ModifyHandling);
        Assert.AreEqual(0.0, part.ModifyGrip);
    }
}






