using serfid.Interfaces.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.ValueObjects;
using serfid.Interfaces.Storage;

namespace serfid.Filter
{
    public class ArduinoRC522Protocol : IFilter
    {
        #region Attributes

        private const int validLength = 26;
        private readonly IStorage _storage;

        #endregion

        #region Constructor

        public ArduinoRC522Protocol(IStorage storage)
        {
            _storage = storage;
        }

        #endregion

        #region Public methods

        public ModuleStatus Start()
        {
            Console.WriteLine("Filter module started!");
            return ModuleStatus.success;
        }

        public FilterResult Tramit(string weft)
        {
            try
            {
                ReadingInfo information = GetReadingInfo(weft);
                _storage.SaveReading(information);

                return FilterResult.Acepted;
            }
            catch
            {
                return FilterResult.Discard;
            }
        }

        #endregion

        #region Private methods

        private ReadingInfo GetReadingInfo(string weft)
        {
            return new ReadingInfo
            {
                Reader = "Puerta 1",
                ReadingDateTime = DateTime.Now,
                Tag = weft
            };
        }

        #endregion
    }
}
