using System;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.Filter;
using serfid.Interfaces.Infraestructure;
using serfid.Interfaces.Listener;

namespace serfid.Listener
{
    public class Listener : IListener
    {
        #region Attributes

        private readonly ITranslator _translator;
        private IFilter _filter;

        #endregion

        #region Constructor

        public Listener(ITranslator translator, IFilter filter)
        {
            _translator = translator;
            _filter = filter;
        }

        #endregion

        #region Public methods

        public ModuleStatus Start()
        {
            Console.WriteLine("Listener module started!");
            return ModuleStatus.success;
        }

        public ReadingResult Read(string encodeReading)
        {
            if (encodeReading == null)
                return ReadingResult.Null;

            if (encodeReading == string.Empty)
                return ReadingResult.Empty;

            string reading = _translator.TranslateReading(encodeReading);

            _filter.Tramit(reading);

            return ReadingResult.Ok;
        }

        #endregion
    }
}