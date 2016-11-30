using System;
using System.Collections.Generic;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.System;
using serfid.Interfaces.User;
using serfid.Interfaces.ValueObjects;
using serfid.Interfaces.Storage;

namespace serfid.User
{
    public class User : IUser
    {
        #region Attributes

        private readonly IStorage _serfidStorage;

        #endregion

        #region Constructor

        public User(IStorage serfidStorage)
        {
            _serfidStorage = serfidStorage;
        }

        #endregion

        #region Public methods

        public ModuleStatus Start()
        {
            Console.WriteLine("User module started!");
            return ModuleStatus.success;
        }

        public IEnumerable<ReadingLog> GetReadings(PagingInfo parameters)
        {
            return _serfidStorage.GetReadings(parameters);
        }

        public bool RegisterDevice(DeviceInfo device)
        {
            return _serfidStorage.RegisterDevice(device);
        }

        #endregion
    }
}
