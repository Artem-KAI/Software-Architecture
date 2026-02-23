namespace DAL.Core.Components;

public sealed class TouchScreen
{
    public bool IsAvailable { get; }

    public TouchScreen(bool available)
    {
        IsAvailable = available;
    }
}
