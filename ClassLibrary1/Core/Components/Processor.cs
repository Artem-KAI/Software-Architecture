namespace DAL.Core.Components;

public sealed class Processor
{
    public string Model { get; }

    public Processor(string model)
    {
        Model = model;
    }
}
