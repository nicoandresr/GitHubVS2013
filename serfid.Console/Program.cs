using System;
using serfid.MainModule;

namespace serfid.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            Serfid appSerfid = new Serfid();
            appSerfid.Run();
            char option = 's';
            while (option == 's')
            {
                System.Console.WriteLine("Insertar una lectura s/n?:");
                ConsoleKeyInfo keyInfo = System.Console.ReadKey();
                option = keyInfo.KeyChar;
                if (option == 's')
                {
                    string reading = System.Console.ReadLine();
                    appSerfid.ReadWeft(reading);
                }
            }
            
        }
    }
}
