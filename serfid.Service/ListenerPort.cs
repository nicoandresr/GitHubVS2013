using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serfid.Service
{
    public class ListenerPort
    {
        #region fields

        private SerialPort _serialPort;
        const string _portName = "TestArduino";

        #endregion

        #region Public mehtods

        public string Open()
        {
            try
            {
                _serialPort = new SerialPort(_portName);
                _serialPort.Open();
                return "Success open port: " + _portName;
            }
            catch(Exception ex)
            {
                return "Can't open the port " + _portName + " error details: " + ex.Message;
            }
        }

        #endregion
    }
}
