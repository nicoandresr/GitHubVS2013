using System;
using System.Collections.Generic;
using serfid.Interfaces.DataAccess;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.System;
using serfid.Interfaces.User;
using serfid.Interfaces.ValueObjects;

namespace serfid.User
{
    public class User : IUser
    {
        #region Attributes

        private readonly ISerfidDataAccess _serfidDataAccess;

        #endregion

        #region Constructor

        public User(ISerfidDataAccess serfidDataAccess)
        {
            _serfidDataAccess = serfidDataAccess;
        }

        #endregion

        #region Public methods

        public ModuleStatus Start()
        {
            Console.WriteLine("User module started!");
            return ModuleStatus.success;
        }

        public List<ReadingInfo> GetReadings(PagingInfo parameters)
        {
            return _serfidDataAccess.GetReadings(parameters);
        }

        #endregion
    }
}
