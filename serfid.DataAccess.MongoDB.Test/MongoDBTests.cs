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
        private static string tag = Guid.NewGuid().ToString().Replace("-", "").ToUpper().Substring(0, 19);

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
                Tag = tag,
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

        [TestMethod]
        public void RegisterDevice()
        {
            // Arrange
            DeviceInfo info = new DeviceInfo
            {
                Tag = tag,
                Device = "Test device " + tag,
                Detail = "Test details for device " + tag,
                Date = DateTime.Now,
                Price = 1500000,
                Rating = 3,
                ImageUrl = "http://www.lenovo.com/images/OneWebImages/FormFactor/Laptops/Thinkpad/400x300/lenovo-laptop-thinkpad-e460-front.png"
            };

            // Act
            _mongoDA.RegisterDevice(info);

            // Assert
            
        }

        #endregion
    }
}
