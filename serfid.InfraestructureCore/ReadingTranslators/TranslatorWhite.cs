using serfid.Interfaces.Infraestructure;

namespace serfid.InfraestructureCore.ReadingTranslators
{
    public class TranslatorWhite : ITranslator
    {
        public string TranslateReading(string encodeReading)
        {
            return encodeReading;
        }
    }
}
