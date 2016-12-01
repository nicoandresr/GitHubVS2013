using serfid.Interfaces.DataAccess;
using System.Linq;
using System.Collections.Generic;
using serfid.Interfaces.System;
using serfid.Interfaces.ValueObjects;
using MongoDB.Driver;
using MongoDB.Bson;
using System;

namespace serfid.DataAccess.MongoDB
{
    public class MongoDataAccess : ISerfidDataAccess
    {
        private readonly IMongoDatabase _db;

        public MongoDataAccess()
        {
            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017/serfid-db");
            _db = mongoClient.GetDatabase("serfid-db");
        }

        public IEnumerable<ReadingLog> GetReadings(PagingInfo parameters)
        {
            List<ReadingLog> result = new List<ReadingLog>();
            IMongoCollection<BsonDocument> collection = _db.GetCollection<BsonDocument>("readings");
            BsonDocument filter = new BsonDocument();
            IFindFluent<BsonDocument, BsonDocument> documents = collection.Find(filter);
            result = documents.ToList().Select(d => new ReadingLog
            {
                Reader = d.GetValue("reader").ToString(),
                Tag = d.GetValue("tag").ToString(),
                ReadingDateTime = d.GetValue("date").ToUniversalTime(),
            }).ToList();
            return result;
        }

        public void SaveReading(ReadingInfo readingInfo)
        {
            IMongoCollection<BsonDocument> collection = _db.GetCollection<BsonDocument>("readings");
            BsonDocument document = new BsonDocument
            {
                { "reader", readingInfo.Reader },
                { "tag", readingInfo.Tag },
                { "date", readingInfo.ReadingDateTime }
            };
            collection.InsertOne(document);
        }

        public void RegisterDevice(DeviceInfo info)
        {
            IMongoCollection<BsonDocument> collection = _db.GetCollection<BsonDocument>("devices");
            BsonDocument document = new BsonDocument
            {
                { "tag", info.Tag },
                { "device", info.Device },
                { "detail", info.Detail },
                { "registerDate", ConvertDateToJsDate(info.Date) },
                { "price", info.Price },
                { "rating", info.Rating },
                { "imageUrl", info.ImageUrl }
            };
            collection.InsertOne(document);
        }

        private double ConvertDateToJsDate(DateTime date)
        {
            return (date.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalMilliseconds;
        }
    }
}
