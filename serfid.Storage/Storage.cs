using System;
using System.Collections.Generic;
using serfid.Interfaces.DataAccess;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.Storage;
using serfid.Interfaces.System;
using serfid.Interfaces.ValueObjects;

namespace serfid.Storage
{
    public class Storage : IStorage
    {
        #region Fields

        private readonly ISerfidDataAccess _dataAccess;

        #endregion

        #region Constructor

        public Storage(ISerfidDataAccess serfidDataAccess)
        {
            _dataAccess = serfidDataAccess;
        }

        #endregion

        #region Public methods

        public ModuleStatus Start()
        {
            Console.WriteLine("Storage started!");
            return ModuleStatus.success;
        }

        public StorageStatus SaveReading(ReadingInfo information)
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

        public IEnumerable<ReadingLog> GetReadings(PagingInfo pagingInfo)
        {
            return _dataAccess.GetReadings(pagingInfo);
        }

        #endregion
    }
}
