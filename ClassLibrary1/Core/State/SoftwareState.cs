using DAL.Core;

namespace DAL.Core.State;

public sealed class SoftwareState
{
    private readonly HashSet<SoftwareType> installedSoftware;

    public SoftwareState()
    {
        installedSoftware = new HashSet<SoftwareType>();
    }

    public bool IsInstalled(SoftwareType softwareType)
    {
        bool isInstalled = installedSoftware.Contains(softwareType);
        return isInstalled;
    }

    public void Install(SoftwareType softwareType)
    {
        bool alreadyInstalled = installedSoftware.Contains(softwareType);

        if (alreadyInstalled == false)
        {
            installedSoftware.Add(softwareType);
        }
    }
}
