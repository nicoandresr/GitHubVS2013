using serfid.Interfaces.Enumerations;
using serfid.Interfaces.ValueObjects;

namespace serfid.Interfaces.Storage
{
    public interface IStorage
    {
        ModuleStatus Start();
        StorageStatus Save(ReadingInfo information);
        bool RegisterDevice(DeviceInfo device);
    }
}