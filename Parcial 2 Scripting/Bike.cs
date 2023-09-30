

pubic class Bike
{
    public double Speed { get; set; }
    public double Acceleration { get; set; }
    public double Handling { get; set; }
    public double Grip { get; set; }

    public FrontWheel FrontWheel { get; set; }
    public BackWheel BackWheel { get; set; }
    public Chassis Chassis { get; set; }
    public Engine Engine { get; set; }
    public Muffler Muffler { get; set; }
}