using System;
using System.Text;
using serfid.Interfaces.Infraestructure;

namespace serfid.InfraestructureCore.ReadingTranslators
{
    public class TranslatorBase64 : ITranslator
    {
        public string TranslateReading(string encodeReading)
        {
            return this.DecodeToBase64(encodeReading);
        }

        private string DecodeToBase64(string encodeReading)
        {
            byte[] base64EncodedBytes = Convert.FromBase64String(encodeReading);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
