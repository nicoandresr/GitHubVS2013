using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serfid.Service
{
    public class ListenerPort : IDisposable
    {
        #region fields

        private SerialPort _serialPort;

        #endregion

        #region Public properties

        public string Name { get { return _serialPort.PortName; } }

        #endregion

        #region Constructor

        public ListenerPort()
        {
            _serialPort = new SerialPort();
        }

        #endregion

        #region Public mehtods

        public string Open()
        {
            try
            {
                _serialPort.Open();
                return "Success open port: " + _serialPort.PortName;
            }
            catch(Exception ex)
            {
                return "Can't open the port " + _serialPort.PortName + " error details: " + ex.Message;
            }
        }

        public string Read()
        {
            try
            {
                return _serialPort.ReadLine();
            }
            catch
            {
                return string.Empty;
            }
        }

        public void Dispose()
        {
            _serialPort.Dispose();
        }

        #endregion
    }
}
