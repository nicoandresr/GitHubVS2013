using System.Collections.Generic;
using serfid.Interfaces.System;
using serfid.Interfaces.ValueObjects;

namespace serfid.Interfaces.DataAccess
{
    public interface ISerfidDataAccess
    {
        void SaveReading(ReadingInfo readingInfo);
        List<ReadingInfo> GetReadings(PagingInfo parameters);
    }
}