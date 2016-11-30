using serfid.Interfaces.ValueObjects;
using System.Collections.Generic;

namespace serfid.Interfaces.MainModule
{
    public interface ISerfid
    {
        void AppStart();
        void ReadWeft(string reading);
        bool RegisterDevice(DeviceInfo device);
        IEnumerable<ReadingLog> GetReadings();
    }
}