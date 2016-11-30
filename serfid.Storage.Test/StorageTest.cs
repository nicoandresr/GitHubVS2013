using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using serfid.Interfaces.DataAccess;
using serfid.Interfaces.Enumerations;
using serfid.Interfaces.Storage;
using serfid.Interfaces.ValueObjects;

namespace serfid.Storage.Test
{
    [TestClass]
    public class StorageTest
    {
        #region Attributes

        private IStorage storage;
        private Mock<ISerfidDataAccess> dataAccessMock;

        #endregion

        #region Initialize

        [TestInitialize]
        public void Initialize()
        {
            dataAccessMock = new Mock<ISerfidDataAccess>();
            storage = new Storage(dataAccessMock.Object);
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void Cleanup()
        {
            storage = null;
            dataAccessMock = null;
        }

        #endregion

        #region Test methods

        [TestMethod]
        public void StartUser()
        {
            //Arrange

            //Act
            ModuleStatus result = storage.Start();

            //Assert
            Assert.AreEqual(ModuleStatus.success, result);
        }

        [TestMethod]
        public void SaveInfomation()
        {
            //Arrange
            ReadingInfo readingInfo = new ReadingInfo();
            dataAccessMock.Setup(d => d.SaveReading(It.IsAny<ReadingInfo>()));

            //Act
            StorageStatus result = storage.SaveReading(readingInfo);

            //Assert
            Assert.AreEqual(StorageStatus.Saved, result);
            dataAccessMock.VerifyAll();
        }


        #endregion
    }
}
