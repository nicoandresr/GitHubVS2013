using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using serfid.Interfaces.ValueObjects;
using System.Collections.Generic;
using serfid.Interfaces.System;

namespace serfid.DataAccess.MongoDB.Test
{
    [TestClass]
    public class MongoDBTests
    {
        #region Fields

        private MongoDataAccess _mongoDA;

        #endregion

        #region Test initialize

        [TestInitialize]
        public void ConnectWithMongoServer()
        {
            // Arrange
            _mongoDA = new MongoDataAccess();

            // Act

            // Assert
            Assert.AreNotEqual(null, _mongoDA);
        }

        #endregion

        #region Test cleanup

        [TestCleanup]
        public void CleanUp()
        {
            _mongoDA = null;
        }

        #endregion

        #region Tests

        [TestMethod]
        public void SaveReading()
        {
            // Arrange
            ReadingInfo info = new ReadingInfo
            {
                Reader = "R2589",
                Tag = Guid.NewGuid().ToString().Replace("-", "").ToUpper().Substring(0, 19),
                ReadingDateTime = DateTime.Now
            };

            // Act
            _mongoDA.SaveReading(info);

            // Assert
        }

        [TestMethod]
        public void GetReadings()
        {
            // Arrange
            List<ReadingInfo> readings = null;

            // Act
            readings = _mongoDA.GetReadings(new PagingInfo());

            // Assert
            Assert.AreNotEqual(null, readings);
        }

        #endregion
    }
}
