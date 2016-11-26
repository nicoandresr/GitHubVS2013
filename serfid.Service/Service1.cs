using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace serfid.Service
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var serialPort1 = new SerialPort("TestArduino");
            serialPort1.Open();
            var read = serialPort1.ReadLine();
        }

        protected override void OnStop()
        {
        }
    }
}
