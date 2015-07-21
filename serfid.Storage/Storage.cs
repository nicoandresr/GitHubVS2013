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
            this._dataAccess = serfidDataAccess;
        }

        public ModuleStatus Start()
        {
            Console.WriteLine("Storage started!");
            return ModuleStatus.success;
        }

        public StorageStatus Save(ReadingInfo information)
        {
            this._dataAccess.SaveReading(information);
            return StorageStatus.Saved;
        }
    }
}
