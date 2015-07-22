using serfid.Interfaces.DataAccess;
using serfid.Interfaces.ValueObjects;

namespace serfid.DataAccess.SqlServerEF
{
    public class SerfidDataAccess : ISerfidDataAccess
    {
        public void SaveReading(ReadingInfo readingInfo)
        {
            Entities entities = new Entities();
            entities.Readings.Add(new Readings
            {
                Tag = readingInfo.Tag,
                Reader = readingInfo.Reader,
                ReadingDateTIme = readingInfo.ReadingDateTime
            });
            entities.SaveChanges();
        }
    }
}