namespace app;

public abstract class Fruit
{
    public string Name { get; set; } = string.Empty;
    public string Colour { get; set; } = string.Empty;
    public int Popularity { get; set; }

    public override string ToString()
    {
        return $"{Name} has is typically coloured {Colour} and has a popularity rating of {Popularity}";
    }
}
