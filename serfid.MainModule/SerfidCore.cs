using System;
using System.Collections.Generic;
using serfid.Interfaces.Filter;
using serfid.Interfaces.Listener;
using serfid.Interfaces.MainModule;
using serfid.Interfaces.Storage;
using serfid.Interfaces.User;
using serfid.Interfaces.ValueObjects;
using serfid.Interfaces.System;

namespace serfid.MainModule
{
    public class SerfidCore : ISerfid
    {
        #region Attributes

        private readonly IListener _listener;
        private readonly IFilter _filter;
        private readonly IStorage _storage;
        private readonly IUser _user;

        #endregion

        #region Constructor

        public SerfidCore(IListener listener, IFilter filter, IStorage storage, IUser user)
        {
            _listener = listener;
            _filter = filter;
            _storage = storage;
            _user = user;
        }

        #endregion

        #region Public methods

        public void AppStart()
        {
            Console.WriteLine("Application started!");
            StartListner();
            StartFilter();
            StartStorage();
            StartUser();
        }

        public void ReadWeft(string reading)
        {
            _listener.Read(reading);
        }

        public bool RegisterDevice(DeviceInfo device)
        {
            return _user.RegisterDevice(device);
        }

        public IEnumerable<ReadingLog> GetReadings()
        {
            PagingInfo pagingInfo = new PagingInfo();
            return _user.GetReadings(pagingInfo);
        }

        #endregion

        #region Private methods

        private void StartListner()
        {
            _listener.Start();
        }

        private void StartFilter()
        {
            _filter.Start();
        }

        private void StartStorage()
        {
            _storage.Start();
        }

        private void StartUser()
        {
            _user.Start();
        }

        #endregion
    }
}
