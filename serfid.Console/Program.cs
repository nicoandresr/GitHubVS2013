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
                    System.Console.WriteLine("\nWaiting for readings...");
                    string reading = _serfidPort.ReadLine();
                    appSerfid.ReadWeft(reading);

                    System.Console.SetCursorPosition(0, System.Console.CursorTop - 1);
                    string result = string.Format("Tag {0} processed successful", reading.Replace("\r", ""));
                    System.Console.WriteLine(result);
                }
            }
            finally
            {
                _serfidPort.Close();
            }
        }
    }
}
