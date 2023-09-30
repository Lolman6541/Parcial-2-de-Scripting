

public class Parameter
{

    public string Name { get; private set; }
    public double Value { get; private set; }

    public Parameter(String name, double value)
    {
        Name = name;
        Value = value;
    }
}