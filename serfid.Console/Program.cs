using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using serfid.MainModule;

namespace serfid.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            Serfid appSerfid = new Serfid();
            appSerfid.Run();
            System.Console.ReadKey();
        }
    }
}
