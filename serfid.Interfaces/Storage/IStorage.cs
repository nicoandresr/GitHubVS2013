using serfid.Interfaces.Enumerations;
using serfid.Interfaces.System;
using serfid.Interfaces.ValueObjects;
using System.Collections.Generic;

namespace serfid.Interfaces.Storage
{
    public interface IStorage
    {
        ModuleStatus Start();

        StorageStatus SaveReading(ReadingInfo readingInfo);
        bool RegisterDevice(DeviceInfo device);
        IEnumerable<ReadingLog> GetReadings(PagingInfo parameters);
    }
}