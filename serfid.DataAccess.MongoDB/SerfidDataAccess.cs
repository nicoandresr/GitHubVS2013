using serfid.Interfaces.DataAccess;
using System;
using System.Collections.Generic;
using serfid.Interfaces.System;
using serfid.Interfaces.ValueObjects;
using MongoDB.Driver;

namespace serfid.DataAccess.MongoDB
{
    public class SerfidDataAccess : ISerfidDataAccess
    {
        private readonly MongoDatabase _mongoDataBase;

        public SerfidDataAccess()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            var mongoServer = mongoClient.GetServer();
            _mongoDataBase = mongoServer.GetDatabase("serfid");
        }

        public List<ReadingInfo> GetReadings(PagingInfo parameters)
        {
            throw new NotImplementedException();
        }

        public void SaveReading(ReadingInfo readingInfo)
        {
            _mongoDataBase.GetStats();
            var buildInfo = _mongoDataBase.Server.BuildInfo;
        }
    }
}
