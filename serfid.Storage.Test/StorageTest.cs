using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        #endregion

        #region Initialize

        [TestInitialize]
        public void Initialize()
        {
            this.storage = new Storage();
        }

        #endregion

        #region Cleanup

        [TestCleanup]
        public void Cleanup()
        {
            this.storage = null;
        }

        #endregion

        #region Test methods

        [TestMethod]
        public void StartFilter()
        {
            //Arrange

            //Act
            ModuleStatus result = this.storage.Start();

            //Assert
            Assert.AreEqual(ModuleStatus.success, result);
        }

        [TestMethod]
        public void SaveInfomation()
        {
            //Arrange
            ReadingInfo readingInfo = new ReadingInfo();

            //Act
            StorageStatus result = this.storage.Save(readingInfo);

            //Assert
            Assert.AreEqual(StorageStatus.Saved, result);
        }


        #endregion
    }
}
