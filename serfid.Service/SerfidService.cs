using serfid.MainModule;
using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace serfid.Service
{
    public partial class SerfidService : ServiceBase
    {
        #region fields

        private Serfid _appSerfid;
        private ListenerPort _listenerPort;

        #endregion

        #region Constructor
        public SerfidService()
        {
            InitializeComponent();

            _appSerfid = new Serfid();
            _listenerPort = new ListenerPort();
        }
        #endregion

        #region Protected methods
        protected override void OnStart(string[] args)
        {
            _listenerPort.Open();

            while (true)
            {
                try
                {
                    string weft = _listenerPort.Read();
                    _appSerfid.ReadWeft(weft);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry
                        ( "Exception throw reading in port: " + _listenerPort != null ? _listenerPort.Name : "'unable create port'"
                        + "\n details: " + ex.Message
                        + "\n call stack: " + ex.StackTrace
                        + "\n inner exception: " + ex.InnerException.Message
                        + "\n inner callStack: " + ex.InnerException.StackTrace);
                }
            }
        }

        protected override void OnStop()
        {
            _appSerfid.Dispose();
            _listenerPort.Dispose();
        }
        #endregion
    }
}
