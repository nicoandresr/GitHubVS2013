using System.Collections.Generic;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.System;
using serfid.Interfaces.ValueObjects;

namespace serfid.Interfaces.User
{
    public interface IUser
    {
        ModuleStatus Start();
        bool RegisterDevice(DeviceInfo device);
        IEnumerable<ReadingLog> GetReadings(PagingInfo parameters);
    }
}