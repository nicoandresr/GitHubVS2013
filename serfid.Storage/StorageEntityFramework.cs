using System;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.Storage;
using serfid.Interfaces.ValueObjects;

namespace serfid.Storage
{
    public class StorageEntityFramework : IStorage
    {
        public ModuleStatus Start()
        {
            Console.WriteLine("Storage started!");
            return ModuleStatus.success;
        }

        public StorageStatus Save(ReadingInfo information)
        {
            return StorageStatus.Saved;
        }
    }
}
