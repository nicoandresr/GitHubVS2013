using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using serfid.Interfaces.DataAccess;
using serfid.Interfaces.System;
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

        public List<ReadingInfo> GetReadings(PagingInfo parameters)
        {
            Entities context = new Entities();
            return context.Readings
                .Skip(() => parameters.Page*parameters.PageSize)
                .Take(() => parameters.PageSize)
                .Select(r => new ReadingInfo {Tag = r.Tag, Reader = r.Reader, ReadingDateTime = r.ReadingDateTIme})
                .ToList();
        }
    }
}