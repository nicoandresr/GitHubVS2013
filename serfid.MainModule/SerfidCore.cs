using System;
using serfid.Interfaces.Filter;
using serfid.Interfaces.Listener;
using serfid.Interfaces.MainModule;
using serfid.Interfaces.Storage;
using serfid.Interfaces.User;
using serfid.Interfaces.ValueObjects;

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
            this.StartListner();
            this.StartFilter();
            this.StartStorage();
            this.StartUser();
        }

        public void ReadWeft(string reading)
        {
            this._listener.Read(reading);
        }

        public bool RegisterDevice(DeviceInfo device)
        {
            return _storage.RegisterDevice(device);
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
            this._user.Start();
        }

        #endregion
    }
}
