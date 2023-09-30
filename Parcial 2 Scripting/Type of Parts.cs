

public class FrontWheel : Part
{
    public override void ModifyParameters(Bike bike)
    {
        bike.Acceleration += 1.0;
        bike.Grip += 1.0;
    }

}

public class BackWheel : Part
{
    public override void ModifyParameters(Bike bike)
    {
        bike.Acceleration += 1.0;
        bike.Grip += 1.0;
    }
}

public class Chassis : Part
{
    public override void ModifyParameters(Bike bike)
    {

    }
}

public class Engine : Part
{
    public override void ModifyParameters(Bike bike)
    {
        bike.Speed += 2.0;
        bike.Acceleration += 1.0;
    }
}

public class Muffler : Part
{
    public override void ModifyParameters(Bike bike)
    {
        bike.Acceleration /= 2.0;
    }
}