using System;
using serfid.MainModule;
using System.IO.Ports;

namespace serfid.Console
{
    static class Program
    {

        private static SerialPort _serfidPort;

        static void Main(string[] args)
        {
            try
            {
                Serfid appSerfid = new Serfid();
                appSerfid.Run();

                _serfidPort = new SerialPort("COM3");
                _serfidPort.Open();

                System.Console.WriteLine("Serfid reading on port: COM3");
                while (true)
                {
                    string reading = _serfidPort.ReadLine();
                    appSerfid.ReadWeft(reading);
                    System.Console.WriteLine("Tag " + reading + " processed successful ");
                }
            }
            finally
            {
                _serfidPort.Close();
            }
        }
    }
}
