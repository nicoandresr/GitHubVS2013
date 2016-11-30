using System;
using serfid.Interfaces.DataAccess;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.Storage;
using serfid.Interfaces.ValueObjects;

namespace serfid.Storage
{
    public class Storage : IStorage
    {
        private readonly ISerfidDataAccess _dataAccess;

        public Storage(ISerfidDataAccess serfidDataAccess)
        {
            _dataAccess = serfidDataAccess;
        }

        public ModuleStatus Start()
        {
            Console.WriteLine("Storage started!");
            return ModuleStatus.success;
        }

        public StorageStatus Save(ReadingInfo information)
        {
            _dataAccess.SaveReading(information);
            return StorageStatus.Saved;
        }

        public bool RegisterDevice(DeviceInfo device)
        {
            try
            {
                _dataAccess.RegisterDevice(device);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
