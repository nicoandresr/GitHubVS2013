using serfid.Interfaces.Listener;
using serfid.Interfaces.ValueObjects;

namespace serfid.Interfaces.MainModule
{
    public interface ISerfid
    {
        void AppStart();
        void ReadWeft(string reading);
        bool RegisterDevice(DeviceInfo device);
    }
}