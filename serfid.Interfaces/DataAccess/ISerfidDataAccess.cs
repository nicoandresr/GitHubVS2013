using serfid.Interfaces.ValueObjects;

namespace serfid.Interfaces.DataAccess
{
    public interface ISerfidDataAccess
    {
        void SaveReading(ReadingInfo readingInfo);
    }
}