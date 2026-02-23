namespace DAL.Core.Components;

public sealed class Memory
{
    public int SizeGb { get; }

    public Memory(int sizeGb)
    {
        SizeGb = sizeGb;
    }
}
